using MeControla.Core.Data.Dtos;
using System;

namespace MeControla.StockAnalytics.WPF.Extensions
{
    public static class WPFFormExtensions
    {
        public static Guid GetValueOrDefault<T>(this T obj)
            where T : class, IDto
            => obj?.Id ?? Guid.Empty;

        public static string GetValueOrDefault<T>(this T obj, Func<T, string> value)
            where T : class, IDto
            => GetValueOrDefault<T, string>(obj, value);

        public static int GetValueOrDefault<T>(this T obj, Func<T, int> value)
            where T : class, IDto
            => GetValueOrDefault<T, int>(obj, value);

        public static TValue GetValueOrDefault<TInput, TValue>(TInput obj, Func<TInput, TValue> value)
            where TInput : class, IDto
        {
            if (obj == null)
                return default;

            return value(obj);
        }
    }
}