using Barricade.ViewModels;
using ReactiveUI.Fody.Helpers;

namespace ArFiApp.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    [Reactive] public MainViewModel ShownView { get; set; } = new();
}