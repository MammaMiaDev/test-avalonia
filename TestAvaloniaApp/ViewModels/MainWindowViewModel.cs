namespace TestAvaloniaApp.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public MainWindowViewModel()
    {
        Greeting = "Runtime Greeting";
    }

    public string Greeting { get; set; }
}
