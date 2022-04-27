using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;


namespace SimulationApp
{
  /// <summary>
  /// Interaction logic for StartScreen.xaml
  /// </summary>
  public partial class StartScreen : Page
  {
    public StartScreen()
    {
      InitializeComponent();
    }

    private void ContinueButton_Click(object sender, RoutedEventArgs e)
    {
      _ = NavigationService.Navigate(Utilities.GenerateNewUri("HomeScreen.xaml"));
    }
  }
}
