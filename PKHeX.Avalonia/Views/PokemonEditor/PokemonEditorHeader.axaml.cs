using Avalonia.Controls;
using Avalonia.Interactivity;
using PKHeX.Avalonia.ViewModels;
using PKHeX.Avalonia.Views.Legality;

namespace PKHeX.Avalonia.Views.PokemonEditor;

public sealed partial class PokemonEditorHeader : UserControl
{
    public PokemonEditorHeader() => InitializeComponent();

    private async void OnQrClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is not PokemonEditorViewModel vm || !vm.HasSpecies)
            return;
        if (TopLevel.GetTopLevel(this) is not Window owner)
            return;
        await new QRCodeWindow(vm.GetEntityClone()).ShowDialog(owner);
    }

    private async void OnLegalityClicked(object? sender, RoutedEventArgs e)
    {
        if (DataContext is not PokemonEditorViewModel vm || !vm.HasSpecies)
            return;
        if (TopLevel.GetTopLevel(this) is not Window owner)
            return;
        await new LegalityReportWindow(vm.GetEntityClone()).ShowDialog(owner);
    }
}
