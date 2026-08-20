using Avalonia.Controls;
using Avalonia.Interactivity;
using PKHeX.Avalonia.ViewModels;

namespace PKHeX.Avalonia.Views.PokemonEditor;

public sealed partial class PokemonEditorOrigin : UserControl
{
    public PokemonEditorOrigin() => InitializeComponent();

    private void OnCycleOTGenderClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is PokemonEditorViewModel vm)
            vm.CycleOTGender();
    }
}
