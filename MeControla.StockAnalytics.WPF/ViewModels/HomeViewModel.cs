using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using MeControla.Core.Extensions;
using MeControla.StockAnalytics.WPF.Business;
using Microsoft.DotNetCore.Hosting.WPF;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MeControla.StockAnalytics.WPF.ViewModels
{
    public partial class HomeViewModel : BaseViewModel
    {
        private readonly IConsolidatedBusiness consolidatedBusiness;
        private readonly IWalletBusiness walletBusiness;

        public IEnumerable<ISeries> Series1 { get; set; }
        public IEnumerable<ISeries> Series2 { get; set; }

        public HomeViewModel(CancellationTokenSource cancellationTokenSource,
                             IConsolidatedBusiness consolidatedBusiness,
                             IWalletBusiness walletBusiness)
        {
            this.consolidatedBusiness = consolidatedBusiness;
            this.walletBusiness = walletBusiness;

            var cancellationToken = cancellationTokenSource.Token;

            _ = LoadData(cancellationToken);

            Series2 = [
                new LineSeries<double>
                {
                    Values = [2, 1, 3, 5, 3, 4, 6],
                    Fill = null
                }
            ];
        }

        private async Task LoadData(CancellationToken cancellationToken)
        {
            var walletList = await walletBusiness.GetAllActiveWithTickersAsync(cancellationToken);

            WalletDataCollection.AddList(walletList);

            if (WalletDataCollection.Count == 1)
                WalletSelected = WalletDataCollection.First();

            var consolidated = await consolidatedBusiness.GetAllByWalletIdWithAmountAsync(WalletSelected.Id, cancellationToken);

            Series1 = consolidated.Select(itm =>
            {
                return new PieSeries<long>
                {
                    Values = [itm.Amount],
                    DataLabelsPaint = new SolidColorPaint(SKColors.White)
                    {
                        SKTypeface = SKTypeface.FromFamilyName("Arial", SKFontStyle.Bold)
                    },
                    DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                    DataLabelsFormatter = point => $" {itm.Ticker.Name} {point.StackedValue.Share:P0}",
                    ToolTipLabelFormatter = point =>
                    {
                        var sv = point.StackedValue!;

                        var amount = itm.Amount;
                        var ticker = itm.Ticker.Name;
                        var total = itm.Total;

                        return $"{ticker} - {sv.Share:P0}{Environment.NewLine}{total:C2} ({amount})";
                    }
                };
            }).ToList();
        }
    }
}