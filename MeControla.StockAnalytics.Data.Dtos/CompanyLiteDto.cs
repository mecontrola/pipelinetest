using MeControla.Core.Data.Dtos;
using System;

namespace MeControla.StockAnalytics.Data.Dtos
{
    public class CompanyLiteDto : IDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}