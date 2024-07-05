using MeControla.Core.WPF.Business;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.FilterInputs;
using MeControla.StockAnalytics.Data.Dtos.Inputs;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CoreBusiness = MeControla.StockAnalytics.Core.Business.IRegisterBusiness;

namespace MeControla.StockAnalytics.WPF.Business
{
    public interface IRegisterBusiness : IBaseFormViewModelBusiness<RegisterDto, RegisterInputDto>, IBaseListViewModelBusiness<RegisterDto, RegisterFilterInputDto>
    { }

    public sealed class RegisterBusiness(CoreBusiness business) : IRegisterBusiness
    {
        public async Task<IList<RegisterDto>> GetFilterAllAsync(RegisterFilterInputDto filter, CancellationToken cancellationToken)
            => await business.RetrieveFilterListAsync(filter, cancellationToken);

        public async Task<bool> SwitchAtiveInactiveAsync(Guid id, CancellationToken cancellationToken)
            => await business.SwitchAtiveInactiveAsync(id, cancellationToken);

        public async Task<RegisterDto> GetAsync(Guid id, CancellationToken cancellationToken)
            => await business.GetAsync(id, cancellationToken);

        public async Task<bool> SaveAsync(Guid? id, RegisterInputDto input, CancellationToken cancellationToken)
            => await business.SaveAsync(id, input, cancellationToken);
    }
}