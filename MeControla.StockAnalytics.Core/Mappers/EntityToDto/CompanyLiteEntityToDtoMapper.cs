using AutoMapper;
using MeControla.Core.Mappers;
using MeControla.StockAnalytics.Data.Dtos;
using MeControla.StockAnalytics.Data.Entities;
using System;

namespace MeControla.StockAnalytics.Core.Mappers.EntityToDto
{
#if DEBUG
    public
#else
    internal
#endif
    interface ICompanyLiteEntityToDtoMapper : IEntityToDtoMapper<Company, CompanyLiteDto>
    { }

#if DEBUG
    public
#else
    internal
#endif
    sealed class CompanyLiteEntityToDtoMapper : BaseMapper<Company, CompanyLiteDto>, ICompanyLiteEntityToDtoMapper
    {
        protected override void MapFields(IMappingExpression<Company, CompanyLiteDto> map)
            => map.ForMember(dest => dest.Id, opt => opt.MapFrom(source => source.Uuid))
                  .ForMember(dest => dest.Name, opt => opt.MapFrom(source => source.Name));
    }
}