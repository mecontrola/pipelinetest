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
    interface ICompanyEntityToDtoMapper : IEntityToDtoMapper<Company, CompanyDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class CompanyEntityToDtoMapper : BaseMapper<Company, CompanyDto>, ICompanyEntityToDtoMapper
    {
        protected override void MapFields(IMappingExpression<Company, CompanyDto> map)
            => map.ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.Uuid))
                  .ForMember(dest => dest.Name, opt => opt.MapFrom(source => source.Name))
                  .ForMember(dest => dest.B3Code, opt => opt.MapFrom(source => source.B3Code))
                  .ForMember(dest => dest.Document, opt => opt.MapFrom(source => source.Document))
                  .ForMember(dest => dest.Active, opt => opt.MapFrom(source => source.Active))
                  .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(source => source.CreatedAt))
                  .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(source => source.UpdatedAt));
    }
}