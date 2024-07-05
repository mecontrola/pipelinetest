using MeControla.StockAnalytics.Core.Builders;
using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Core.Validators;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface ICompanySaveService : IBaseEntitySaveService<CompanyInputDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class CompanySaveService(ICompanyRepository companyRepository,
                                    ICompanyInputDtoValidator companyInputDtoValidator)
        : BaseEntitySaveService<Company, CompanyInputDto>(companyRepository, companyInputDtoValidator), ICompanySaveService
    {
        protected override void FillEntity(Company entity, CompanyInputDto input)
        {
            entity.Name = input.Name;
            entity.B3Code = input.B3Code;
            entity.Document = input.Document;

            if (entity.Id == 0)
                entity.Active = true;
        }

        protected override Company BuildEntity()
            => CompanyBuilder.GetInstance().ToBuild();
    }
}