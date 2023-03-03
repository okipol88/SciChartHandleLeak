using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SciChartHandleLeak
{
  public class FirstViewModel
  {

  }
  public class SecondViewModel
  {

  }

  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }






    public object Item
    {
      get { return (object)GetValue(ItemProperty); }
      set { SetValue(ItemProperty, value); }
    }

    // Using a DependencyProperty as the backing store for Item.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty ItemProperty =
        DependencyProperty.Register("Item", typeof(object), typeof(MainWindow), new PropertyMetadata(null));

    private void Button_Click(object sender, RoutedEventArgs e)
    {
      ToggleVm();
    }

    private void ToggleVm()
    {
      if (Item is FirstViewModel)
      {
        Item = new SecondViewModel();
      }
      else
      {
        Item = new FirstViewModel();
      }
    }

    private void Button_Click_1(object sender, RoutedEventArgs e)
    {
      ToggleVm();
    }
  }
}
