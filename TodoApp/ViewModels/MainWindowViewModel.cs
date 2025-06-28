using ReactiveUI;
using System.Collections.ObjectModel;
using System.Reactive;

using TodoApp.Models;

namespace TodoApp.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    // Add items.
    private string _newTask = "";
    public string NewTask
    {

    }
}
