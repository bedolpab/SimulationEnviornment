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
  /// Interaction logic for SettingsScreen.xaml
  /// </summary>
  public partial class SettingsScreen : Page
  {
    public SettingsScreen()
    {
      InitializeComponent();
    }

    private void ReturnButton_Click(object sender, RoutedEventArgs e)
    {
      _ = NavigationService.Navigate(Utilities.GenerateNewUri("HomeScreen.xaml"));
    }

    private void RestartButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void TerminateButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void ChangeInformationButton_Click(object sender, RoutedEventArgs e)
    {

    }

    private void ViewProjectInfoButton_Click(object sender, RoutedEventArgs e)
    {

    }
  }
}
