using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Logging;
using GetStartedApp.ViewModels;
using Microsoft.Extensions.Configuration;

partial namespace GetStartedApp.Views;
public partial class LoginWindowView : Window {

    
    public LoginWindowView()
    {
        Logger.TryGet(LogEventLevel.Fatal, LogArea.Control)?.Log(this, "Avalonia Infrastructure");
        System.Diagnostics.Debug.WriteLine("System Diagnostics Debug");
        InitializeComponent();
        login_username.Text = "";
        login_password.Text = "";
        
        LoadSettings();

        Debug.WriteLine($"username and password: {userpass.GetValue(0)}, {userpass.GetValue(1)}");

        if (userpass[0] == "")
        {
            Debug.WriteLine("Woah");
        }
        
    }
    
    private IConfigurationSection pair;
    public void LoadSettings() {
        IConfiguration config = new ConfigurationBuilder()
            .AddJsonFile("appdata.json")
            .Build();

        pair = config.GetSection("Settings");

        String username = pair["username"] ?? "", hashed_password = pair["hashed_password"] ?? ""; 
        
        userpass = [username, hashed_password];
    }

    public String[] userpass = [];

    public void Button_Click(object sender, RoutedEventArgs args) {
        String current_pass = login_password.Text ?? "";
        login_password.Text = "";
        Debug.WriteLine($"{userpass[0]} {login_username.Text}"); 
        Debug.WriteLine($"{userpass[1]} {current_pass}"); 
        if(login_username.Text == userpass[0] && current_pass == userpass[1]) {
          Debug.WriteLine("les go");
          
        } 
        else {
          Debug.WriteLine("nein");
        }
    }
}