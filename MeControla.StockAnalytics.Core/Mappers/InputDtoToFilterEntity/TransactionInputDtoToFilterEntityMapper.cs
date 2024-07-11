using AutoMapper;
using MeControla.Core.Mappers;
using MeControla.StockAnalytics.Data.Dtos.FilterInputs;
using MeControla.StockAnalytics.Data.Entities.Filters;
using MeControla.StockAnalytics.Data.Enums;

namespace MeControla.StockAnalytics.Core.Mappers.InputDtoToFilterEntity
{
#if DEBUG
    public
#else
    internal
#endif
    interface ITransactionInputDtoToFilterEntityMapper : IInputDtoToFilterEntityMapper<TransactionFilterInputDto, TransactionFilter>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class TransactionInputDtoToFilterEntityMapper : BaseMapper<TransactionFilterInputDto, TransactionFilter>, ITransactionInputDtoToFilterEntityMapper
    {
        protected override void MapFields(IMappingExpression<TransactionFilterInputDto, TransactionFilter> map)
            => map.ForMember(dest => dest.BrokerId, opt => opt.MapFrom(source => source.BrokerId))
                  .ForMember(dest => dest.TickerId, opt => opt.MapFrom(source => source.TickerId))
                  .ForMember(dest => dest.WalletId, opt => opt.MapFrom(source => source.WalletId))
                  .ForMember(dest => dest.Action, opt => opt.MapFrom(source => ConvertBoolToEnum(source.IsBuy)));

        private static TransactionAction? ConvertBoolToEnum(bool? isBuy)
            => isBuy.HasValue
             ? ConvertBoolToEnum(isBuy.Value)
             : null;

        private static TransactionAction ConvertBoolToEnum(bool isBuy)
            => isBuy
             ? TransactionAction.Purchase
             : TransactionAction.Sale;
    }
}