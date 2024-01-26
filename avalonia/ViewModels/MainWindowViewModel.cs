
namespace GetStartedApp.ViewModels;

public partial class MainWindowViewModel : ViewModelBase
{

  private ViewModelBase? _currentPage = new LoginWindowViewModel();

#pragma warning disable CA1822 // Mark members as static
    public string Greeting => "Welcome to Avalonia! My name is Xavier!!";
#pragma warning restore CA1822 // Mark members as static
}
