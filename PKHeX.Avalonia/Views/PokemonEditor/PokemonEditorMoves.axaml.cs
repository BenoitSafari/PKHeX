using System;
using Avalonia.Controls;
using PKHeX.Avalonia.ViewModels;

namespace PKHeX.Avalonia.Views.PokemonEditor;

public sealed partial class PokemonEditorMoves : UserControl
{
    public PokemonEditorMoves() => InitializeComponent();

    private void OnMoveDropDownOpened(object? sender, EventArgs e)
    {
        if (DataContext is PokemonEditorViewModel vm)
            vm.EnsureMoveChoicesOrdered(); // re-sort legal-first if legality changed
    }
}
