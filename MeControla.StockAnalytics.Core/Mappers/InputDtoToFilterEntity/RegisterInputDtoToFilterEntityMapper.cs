using AutoMapper;
using MeControla.Core.Mappers;
using MeControla.StockAnalytics.Data.Dtos.FilterInputs;
using MeControla.StockAnalytics.Data.Entities.Filters;

namespace MeControla.StockAnalytics.Core.Mappers.InputDtoToFilterEntity
{
#if DEBUG
    public
#else
    internal
#endif
    interface IRegisterInputDtoToFilterEntityMapper : IInputDtoToFilterEntityMapper<RegisterFilterInputDto, RegisterFilter>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class RegisterInputDtoToFilterEntityMapper : BaseMapper<RegisterFilterInputDto, RegisterFilter>, IRegisterInputDtoToFilterEntityMapper
    {
        protected override void MapFields(IMappingExpression<RegisterFilterInputDto, RegisterFilter> map)
            => map.ForMember(dest => dest.Name, opt => opt.MapFrom(source => source.Name))
                  .ForMember(dest => dest.Active, opt => opt.MapFrom(source => source.Active));
    }
}