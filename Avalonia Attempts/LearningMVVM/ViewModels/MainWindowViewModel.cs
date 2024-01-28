using Avalonia.Controls.Templates;
using Microsoft.CodeAnalysis;
using ReactiveUI;
using System.Diagnostics;
using System.Reactive;

namespace LearningMVVM.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private string _content = "shockers";
    public ReactiveCommand<Unit, Unit> SubmitCommand { get;}

    public string Content
    {
        get { return _content; }
        set { this.RaiseAndSetIfChanged(ref _content, value); }
    }

    public MainWindowViewModel()
    {
        SubmitCommand = ReactiveCommand.Create(() =>
        {
            Debug.WriteLine("Submitted with content: " + _content);
        });
    }
}
