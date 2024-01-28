using System;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using Avalonia.Interactivity;
using ReactiveUI;
using CitationApplication.ViewModels;

namespace CitationApplication.ViewModels {
    public class LoginWindowViewModel : ViewModelBase {
        public LoginWindowViewModel() {
            
        }

        public void Signup_Click()
        {
            Debug.WriteLine("Test!");
        }
    }
}