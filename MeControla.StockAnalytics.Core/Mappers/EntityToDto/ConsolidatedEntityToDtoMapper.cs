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
    interface IConsolidatedEntityToDtoMapper : IEntityToDtoMapper<Consolidated, ConsolidatedDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class ConsolidatedEntityToDtoMapper(ITickerLiteEntityToDtoMapper tickerLiteEntityToDtoMapper,
                                               IWalletLiteEntityToDtoMapper walletLiteEntityToDtoMapper)
        : BaseMapper<Consolidated, ConsolidatedDto>, IConsolidatedEntityToDtoMapper
    {
        protected override void MapFields(IMappingExpression<Consolidated, ConsolidatedDto> map)
            => map.ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.Uuid))
                  .ForMember(dest => dest.Amount, opt => opt.MapFrom(source => source.Amount))
                  .ForMember(dest => dest.Price, opt => opt.MapFrom(source => source.Price))
                  .ForMember(dest => dest.Total, opt => opt.MapFrom(source => source.Total))
                  .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(source => source.CreatedAt))
                  .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(source => source.UpdatedAt))
                  .ForMember(dest => dest.Ticker, opt => opt.MapFrom(source => tickerLiteEntityToDtoMapper.ToMap(source.Ticker)))
                  .ForMember(dest => dest.Wallet, opt => opt.MapFrom(source => walletLiteEntityToDtoMapper.ToMap(source.Wallet)));
    }
}