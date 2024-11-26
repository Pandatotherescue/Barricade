using Barricade.ViewModels;
using ReactiveUI;

namespace ArFiApp.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    [Reactive] public MainViewModel ShownView { get; set; } = new();
}