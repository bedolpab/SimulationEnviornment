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

namespace SimulationApp
{
  /// <summary>
  /// Interaction logic for HomeScreen.xaml
  /// </summary>
  public partial class HomeScreen : Page
  {
    public HomeScreen()
    {
      InitializeComponent();
    }

    private void EntityButton_Click(object sender, RoutedEventArgs e)
    {
      _ = NavigationService.Navigate(Utilities.GenerateNewUri("EntityScreen.xaml"));
    }

    private void SettingsButton_Click(object sender, RoutedEventArgs e)
    {
      _ = NavigationService.Navigate(Utilities.GenerateNewUri("SettingsScreen.xaml"));

    }

    private void SellerButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void PlayerButton_Click(object sender, RoutedEventArgs e)
    {

    }
  }
}
