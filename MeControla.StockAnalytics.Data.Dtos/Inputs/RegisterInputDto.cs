using MeControla.Core.Data.Dtos;

namespace MeControla.StockAnalytics.Data.Dtos.Inputs
{
    public class RegisterInputDto : IInputDto
    {
        public string Name { get; set; }
        public string Website { get; set; }
    }
}