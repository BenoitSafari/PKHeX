using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using PKHeX.Avalonia.ViewModels;
using PKHeX.Avalonia.Views;

namespace PKHeX.Avalonia;

public sealed class App : Application
{
    public override void Initialize() => AvaloniaXamlLoader.Load(this);

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var vm = new MainWindowViewModel();
            desktop.MainWindow = new MainWindow { DataContext = vm };

            // Allow opening a save file passed on the command line.
            if (desktop.Args is [{ Length: > 0 } path, ..])
                vm.LoadSaveFromPath(path);
        }

        base.OnFrameworkInitializationCompleted();
    }
}
