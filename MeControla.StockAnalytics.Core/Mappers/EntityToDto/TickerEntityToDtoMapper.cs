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
    interface ITickerEntityToDtoMapper : IEntityToDtoMapper<Ticker, TickerDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class TickerEntityToDtoMapper(ICompanyLiteEntityToDtoMapper companyLiteEntityToDtoMapper) : BaseMapper<Ticker, TickerDto>, ITickerEntityToDtoMapper
    {
        protected override void MapFields(IMappingExpression<Ticker, TickerDto> map)
            => map.ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.Uuid))
                  .ForMember(dest => dest.Name, opt => opt.MapFrom(source => source.Name))
                  .ForMember(dest => dest.ISINCode, opt => opt.MapFrom(source => source.ISINCode))
                  .ForMember(dest => dest.Active, opt => opt.MapFrom(source => source.Active))
                  .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(source => source.CreatedAt))
                  .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(source => source.UpdatedAt))
                  .ForMember(dest => dest.Company, opt => opt.MapFrom(source => companyLiteEntityToDtoMapper.ToMap(source.Company)));
    }
}