using System;
using System.Diagnostics;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Logging;
using Microsoft.Extensions.Configuration;

namespace CitationApplication.Views {

    public partial class LoginWindowView : UserControl
    {
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

    public LoginWindowView()
    {
        Logger.TryGet(LogEventLevel.Fatal, LogArea.Control)?.Log(this, "Avalonia Infrastructure");
        Debug.WriteLine("System Diagnostics Debug");
        InitializeComponent();
        LoadSettings();
        Debug.WriteLine("dd");
    }

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
}