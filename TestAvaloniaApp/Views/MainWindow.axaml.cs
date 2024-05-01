using Avalonia.Controls;
using TestAvaloniaApp.ViewModels;

namespace TestAvaloniaApp.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainWindowViewModel();
    }
}
