﻿using System;
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
  /// Interaction logic for EntityScreen.xaml
  /// </summary>
  public partial class EntityScreen : Page
  {
    public EntityScreen()
    {
      InitializeComponent();
    }

    private void ReturnButton_Click(object sender, RoutedEventArgs e)
    {
      _ = NavigationService.Navigate(Utilities.GenerateNewUri("HomeScreen.xaml"));
    }
  }
}
