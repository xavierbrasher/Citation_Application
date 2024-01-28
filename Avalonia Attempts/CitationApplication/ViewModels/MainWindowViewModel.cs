using ReactiveUI;


namespace CitationApplication.ViewModels {

    public class MainWindowViewModel : ViewModelBase
    {
        public ViewModelBase _contentViewModel;

        public MainWindowViewModel()
        {
            _contentViewModel = new LoginWindowViewModel();
        }
                
        public ViewModelBase ContentViewModel
        {
            get => _contentViewModel;
            private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
        }

        public void ChangeViewModel(ViewModelBase changedto)
        {
            _contentViewModel = changedto;
        }



#pragma warning disable CA1822 // Mark members as static
        public string Greeting => "Welcome to Avalonia!";
    #pragma warning restore CA1822 // Mark members as static
    }
}