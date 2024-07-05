using AutoMapper;
using MeControla.Core.Mappers;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Entities;

namespace MeControla.StockAnalytics.Core.Mappers.EntityToDto
{
#if DEBUG
    public
#else
    internal
#endif
    interface IBrokerLiteEntityToDtoMapper : IEntityToDtoMapper<Broker, BrokerLiteDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class BrokerLiteEntityToDtoMapper : BaseMapper<Broker, BrokerLiteDto>, IBrokerLiteEntityToDtoMapper
    {
        protected override void MapFields(IMappingExpression<Broker, BrokerLiteDto> map)
            => map.ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.Uuid))
                  .ForMember(dest => dest.Name, opt => opt.MapFrom(source => source.Name));
    }
}