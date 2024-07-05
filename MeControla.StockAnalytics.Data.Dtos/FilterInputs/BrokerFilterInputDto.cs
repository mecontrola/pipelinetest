using MeControla.Core.Data.Dtos;

namespace MeControla.StockAnalytics.Data.Dtos.FilterInputs
{
    public class BrokerFilterInputDto : IInputDto
    {
        public string Name { get; set; }
        public bool? Active { get; set; }
    }
}