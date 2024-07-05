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
    interface IBrokerInputDtoToFilterEntityMapper : IInputDtoToFilterEntityMapper<BrokerFilterInputDto, BrokerFilter>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class BrokerInputDtoToFilterEntityMapper : BaseMapper<BrokerFilterInputDto, BrokerFilter>, IBrokerInputDtoToFilterEntityMapper
    {
        protected override void MapFields(IMappingExpression<BrokerFilterInputDto, BrokerFilter> map)
            => map.ForMember(dest => dest.Name, opt => opt.MapFrom(source => source.Name))
                  .ForMember(dest => dest.Active, opt => opt.MapFrom(source => source.Active));
    }
}