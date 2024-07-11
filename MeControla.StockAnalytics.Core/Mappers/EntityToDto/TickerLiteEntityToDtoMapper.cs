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
    interface ITickerLiteEntityToDtoMapper : IEntityToDtoMapper<Ticker, TickerLiteDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class TickerLiteEntityToDtoMapper : BaseMapper<Ticker, TickerLiteDto>, ITickerLiteEntityToDtoMapper
    {
        protected override void MapFields(IMappingExpression<Ticker, TickerLiteDto> map)
            => map.ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.Uuid))
                  .ForMember(dest => dest.Name, opt => opt.MapFrom(source => source.Name));
    }
}