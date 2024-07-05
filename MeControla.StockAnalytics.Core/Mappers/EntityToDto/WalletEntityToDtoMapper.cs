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
    interface IWalletEntityToDtoMapper : IEntityToDtoMapper<Wallet, WalletDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class WalletEntityToDtoMapper : BaseMapper<Wallet, WalletDto>, IWalletEntityToDtoMapper
    {
        protected override void MapFields(IMappingExpression<Wallet, WalletDto> map)
            => map.ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.Uuid))
                  .ForMember(dest => dest.Name, opt => opt.MapFrom(source => source.Name))
                  .ForMember(dest => dest.Active, opt => opt.MapFrom(source => source.Active))
                  .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(source => source.CreatedAt))
                  .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(source => source.UpdatedAt));
    }
}