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
    interface ICompanyInputDtoToFilterEntityMapper : IInputDtoToFilterEntityMapper<CompanyFilterInputDto, CompanyFilter>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class CompanyInputDtoToFilterEntityMapper : BaseMapper<CompanyFilterInputDto, CompanyFilter>, ICompanyInputDtoToFilterEntityMapper
    {
        protected override void MapFields(IMappingExpression<CompanyFilterInputDto, CompanyFilter> map)
            => map.ForMember(dest => dest.Name, opt => opt.MapFrom(source => source.Name))
                  .ForMember(dest => dest.Active, opt => opt.MapFrom(source => source.Active));
    }
}