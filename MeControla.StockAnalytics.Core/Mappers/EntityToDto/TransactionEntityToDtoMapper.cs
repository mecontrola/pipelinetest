﻿using AutoMapper;
using MeControla.Core.Mappers;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Entities;
using MeControla.StockAnalytics.Data.Enums;

namespace MeControla.StockAnalytics.Core.Mappers.EntityToDto
{
#if DEBUG
    public
#else
    internal
#endif
    interface ITransactionEntityToDtoMapper : IEntityToDtoMapper<Transaction, TransactionDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class TransactionEntityToDtoMapper(IBrokerLiteEntityToDtoMapper brokerLiteEntityToDtoMapper,
                                              ITickerLiteEntityToDtoMapper tickerLiteEntityToDtoMapper,
                                              IWalletLiteEntityToDtoMapper walletLiteEntityToDtoMapper)
        : BaseMapper<Transaction, TransactionDto>, ITransactionEntityToDtoMapper
    {
        protected override void MapFields(IMappingExpression<Transaction, TransactionDto> map)
            => map.ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.Uuid))
                  .ForMember(dest => dest.Date, opt => opt.MapFrom(source => source.Date))
                  .ForMember(dest => dest.Amount, opt => opt.MapFrom(source => source.Amount))
                  .ForMember(dest => dest.Price, opt => opt.MapFrom(source => source.Price))
                  .ForMember(dest => dest.Total, opt => opt.MapFrom(source => source.Total))
                  .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(source => source.CreatedAt))
                  .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(source => source.UpdatedAt))
                  .ForMember(dest => dest.IsBuy, opt => opt.MapFrom(source => IsBuy(source.Action)))
                  .ForMember(dest => dest.Broker, opt => opt.MapFrom(source => brokerLiteEntityToDtoMapper.ToMap(source.Broker)))
                  .ForMember(dest => dest.Ticker, opt => opt.MapFrom(source => tickerLiteEntityToDtoMapper.ToMap(source.Ticker)))
                  .ForMember(dest => dest.Wallet, opt => opt.MapFrom(source => walletLiteEntityToDtoMapper.ToMap(source.Wallet)));

        private static bool IsBuy(TransactionAction action)
            => action.Equals(TransactionAction.Purchase);
    }
}