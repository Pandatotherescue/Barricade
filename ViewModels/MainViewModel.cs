using ReactiveUI;


namespace Barricade.ViewModels;

public class MainViewModel : ViewModelBase
{
    
    [Reactive] public ControlsViewModel ControlScreenViewModel { get; set; } = new();
}