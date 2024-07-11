using MeControla.StockAnalytics.Core.Mappers.EntityToDto;
using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface IRegisterRetrieveService : IBaseEntityRetrieveService<RegisterDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class RegisterRetrieveService(IRegisterRepository registerRepository,
                                         IRegisterEntityToDtoMapper registerEntityToDtoMapper)
        : BaseEntityRetrieveService<Register, RegisterDto>(registerRepository, registerEntityToDtoMapper), IRegisterRetrieveService
    { }
}