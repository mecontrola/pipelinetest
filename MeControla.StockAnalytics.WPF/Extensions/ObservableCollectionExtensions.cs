using MeControla.Core.Data.Dtos;
using System.Collections.ObjectModel;
using System.Linq;

namespace MeControla.StockAnalytics.WPF.Extensions
{
    public static class ObservableCollectionExtensions
    {
        public static T SelectOrDefault<T>(this ObservableCollection<T> obj, T value)
            where T : class, IDto
            => obj.FirstOrDefault(itm => itm.Id.Equals(value?.Id));
    }
}