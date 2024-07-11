using MeControla.Core.Data.Dtos;

namespace MeControla.StockAnalytics.Data.Dtos.FilterInputs
{
    public class CompanyFilterInputDto : IInputDto
    {
        public string Name { get; set; }
        public bool? Active { get; set; }
    }
}