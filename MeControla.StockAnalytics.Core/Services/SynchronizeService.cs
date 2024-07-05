using MeControla.Core.Extensions;
using MeControla.Core.Integrations.B3.Data.Dtos;
using MeControla.Core.Integrations.B3.Rest;
using MeControla.StockAnalytics.Core.Builders;
using MeControla.StockAnalytics.DataStorage.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface ISynchronizeService
    {
        Task RunAllAsync(CancellationToken cancellationToken);
    }

#if DEBUG
    public
#else
    internal
#endif
    sealed class SynchronizeService(ILogger<SynchronizeService> logger,
                                    ICompanyGet companyGet,
                                    ICompanyGetAll companyGetAll,
                                    IFundsGet fundsGet,
                                    IFundsGetAll fundsGetAll,
                                    ICompanyRepository companyRepository,
                                    ITickerRepository tickerRepository)
        : ISynchronizeService
    {
        private const string ERROR_SYNC_COMPANY_MESSAGE = "Error to synchronize company with CVM Code: {0}";
        private const string INFO_SYNC_COMPANY_MESSAGE = "The company with {0} CVM Code has inconsistent informations.";

        private const string ERROR_SYNC_FUND_MESSAGE = "Error to synchronize fund with acronym: {0}";
        private const string INFO_SYNC_FUND_MESSAGE = "The fund with {0} acronym has inconsistent informations.";

        public async Task RunAllAsync(CancellationToken cancellationToken)
        {
            var listCompany = await companyGetAll.GetResultAsync(cancellationToken);

            foreach (var item in listCompany)
            {
                try
                {
                    var company = await companyGet.GetResultAsync(item.CodeCVM, cancellationToken);

                    if (!IsCompanyValid(company))
                    {
                        logger.LogInformation(INFO_SYNC_COMPANY_MESSAGE, item.CodeCVM);

                        continue;
                    }

                    var entityCompany = await companyRepository.GetByB3CodeAsync(company.CodeCVM, cancellationToken);

                    if (entityCompany == null)
                    {
                        entityCompany = CompanyBuilder.GetInstance()
                                                      .SetName(company.CompanyName)
                                                      .SetB3Code(company.CodeCVM)
                                                      .SetDocument(company.Cnpj)
                                                      .ToBuild();

                        entityCompany = await companyRepository.CreateAsync(entityCompany, cancellationToken);
                    }

                    foreach (var ticker in company.OtherCodes)
                    {
                        var entityTicker = await tickerRepository.GetByNameAsync(ticker.Code, cancellationToken);

                        if (entityTicker != null)
                            continue;

                        entityTicker = TickerBuilder.GetInstance()
                                                    .SetName(ticker.Code)
                                                    .SetISINCode(ticker.ISIN)
                                                    .SetCompanyId(entityCompany.Id)
                                                    .ToBuild();

                        await tickerRepository.CreateAsync(entityTicker, cancellationToken);
                    }
                }
                catch (Exception e)
                {
                    logger.LogError(e, ERROR_SYNC_COMPANY_MESSAGE, item.CodeCVM);
                }
            }

            var listFunds = await fundsGetAll.GetResultAsync(cancellationToken);


            foreach (var item in listFunds)
            {
                try
                {
                    var fund = await fundsGet.GetResultAsync(item.Acronym, cancellationToken);

                    if (!IsFundValid(fund))
                    {
                        logger.LogInformation(INFO_SYNC_FUND_MESSAGE, item.Acronym);

                        continue;
                    }

                    var entityCompany = await companyRepository.GetByB3CodeAsync(item.Acronym, cancellationToken);

                    if (entityCompany == null)
                    {
                        entityCompany = CompanyBuilder.GetInstance()
                                                      .SetName(fund.DetailFund.TradingName)
                                                      .SetB3Code(item.Acronym)
                                                      .SetDocument(fund.DetailFund.Cnpj)
                                                      .ToBuild();

                        entityCompany = await companyRepository.CreateAsync(entityCompany, cancellationToken);
                    }

                    foreach (var ticker in fund.DetailFund.Codes)
                    {
                        var entityTicker = await tickerRepository.GetByNameAsync(ticker, cancellationToken);

                        if (entityTicker != null)
                            continue;

                        entityTicker = TickerBuilder.GetInstance()
                                                    .SetName(ticker)
                                                    .SetCompanyId(entityCompany.Id)
                                                    .ToBuild();

                        await tickerRepository.CreateAsync(entityTicker, cancellationToken);
                    }
                }
                catch (Exception e)
                {
                    logger.LogError(e, ERROR_SYNC_FUND_MESSAGE, item.Acronym);
                }
            }
        }

        private static bool IsCompanyValid(CompanyDetailDto company)
            => company != null
            && company.OtherCodes.IsNotNullAndAny()
            && !company.Cnpj.IsNullOrWhiteSpace();

        private static bool IsFundValid(FundDetailDto fund)
            => fund != null
            && fund.DetailFund != null
            && fund.DetailFund.Codes.IsNotNullAndAny()
            && !fund.DetailFund.Cnpj.IsNullOrWhiteSpace();
    }
}