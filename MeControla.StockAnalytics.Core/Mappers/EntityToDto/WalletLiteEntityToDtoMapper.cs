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
    interface IWalletLiteEntityToDtoMapper : IEntityToDtoMapper<Wallet, WalletLiteDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class WalletLiteEntityToDtoMapper : BaseMapper<Wallet, WalletLiteDto>, IWalletLiteEntityToDtoMapper
    {
        protected override void MapFields(IMappingExpression<Wallet, WalletLiteDto> map)
            => map.ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.Uuid))
                  .ForMember(dest => dest.Name, opt => opt.MapFrom(source => source.Name));
    }
}