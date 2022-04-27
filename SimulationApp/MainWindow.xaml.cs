using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace SimulationApp
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
    }

    private void MainGrid_Loaded(object sender, RoutedEventArgs e)
    {
      // Load page 'StartScreen'
      _ = Frame.Navigate(new StartScreen());
    }
  }
}
