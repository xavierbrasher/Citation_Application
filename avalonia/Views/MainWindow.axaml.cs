using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Interactivity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace GetStartedApp.Views;

public partial class MainWindow : Window
{
    private IConfigurationSection pair;
    public void loadSettings() {
      IConfiguration config = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();

      // Get a configuration section
      pair = config.GetSection("Settings");

        // check the Output
      Debug.WriteLine($"lastActiveDevice: {pair["lastActiveDevice"]}");
      Debug.WriteLine($"autoOpen: {pair["autoOpen"]}");
      return;
    }
    public MainWindow()
    {
        InitializeComponent();
        loadSettings();
    }

    public void Button_Click(object sender, RoutedEventArgs args) {
        Olle.Text = "Im dead cuh and not currently mewing";
    }
}