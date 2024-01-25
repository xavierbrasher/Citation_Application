using System;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Interactivity;
using Avalonia.Logging;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace GetStartedApp.Views;

public partial class MainWindow : Window
{
    private IConfigurationSection pair;
    public void LoadSettings() {
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appdata.json")
            .Build();

        pair = config.GetSection("Settings");

        String username = pair["username"], hashed_password = pair["hashed_password"];
        
        if (username == null || hashed_password == null)
        {
            userpass = ["cuh", ""];
            return;
        }
        userpass = [username, hashed_password];
    }

    public String[] userpass = [];

    public MainWindow()
    {
        Logger.TryGet(LogEventLevel.Fatal, LogArea.Control)?.Log(this, "Avalonia Infrastructure");
        System.Diagnostics.Debug.WriteLine("System Diagnostics Debug");
        InitializeComponent();
        
        LoadSettings();

        Debug.WriteLine($"username and password: {userpass.GetValue(0)}, {userpass.GetValue(1)}");

        if (userpass[0] == "cuh")
        {
            Debug.WriteLine("Woah");
        }
        
    }

    public void Button_Click(object sender, RoutedEventArgs args) {
        Debug.WriteLine("eelo cug");
        login_password.Text = "";

    }
}