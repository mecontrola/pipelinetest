using MeControla.StockAnalytics.Core.Mappers.EntityToDto;
using MeControla.StockAnalytics.Core.Mappers.InputDtoToFilterEntity;
using MeControla.StockAnalytics.Core.Services.Bases;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Dtos.FilterInputs;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.Data.Entities.Filters;
using MeControla.StockAnalytics.DataStorage.Repositories;

namespace MeControla.StockAnalytics.Core.Services
{
    public interface IRegisterRetrieveFilterListService : IBaseEntityRetrieveFilterListService<RegisterDto, RegisterFilterInputDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class RegisterRetrieveFilterListService(IRegisterRepository registerRepository,
                                                   IRegisterInputDtoToFilterEntityMapper registerInputDtoToFilterEntityMapper,
                                                   IRegisterEntityToDtoMapper registerEntityToDtoMapper)
        : BaseEntityRetrieveFilterListService<Register, RegisterDto, RegisterFilter, RegisterFilterInputDto>(registerRepository,
                                                                                                             registerInputDtoToFilterEntityMapper,
                                                                                                             registerEntityToDtoMapper)
        , IRegisterRetrieveFilterListService
    { }
}