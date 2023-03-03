using SciChart.Charting.Visuals;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SciChartHandleLeak
{
  /// <summary>
  /// Interaction logic for App.xaml
  /// </summary>
  public partial class App : Application
  {

    protected override void OnStartup(StartupEventArgs e)
    {
      base.OnStartup(e);


      var runtimeLicenseKey = "";
      string tempDirectory = null;
      var loadingTask = SciChart2DInitializer.LoadLibrariesAndLicenseAsync(runtimeLicenseKey, tempDirectory);

      loadingTask.ContinueWith(t =>
      {
        System.Diagnostics.Debug.WriteLine($"SciChart loaded: {t.Status} => {t.Exception}");

        new SciChartSurface();

      }, TaskScheduler.FromCurrentSynchronizationContext());


    }

  }
}
