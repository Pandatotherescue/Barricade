using System;
using ReactiveUI;
using Avalonia;



namespace Barricade.ViewModels;

public class MainViewModel : ViewModelBase
{
    
    [Reactive] public ControlsViewModel ControlScreenViewModel { get; set; } = new();
}

public class ReactiveAttribute : Attribute
{
}