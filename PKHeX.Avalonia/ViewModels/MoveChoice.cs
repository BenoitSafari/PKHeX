using Avalonia.Media.Imaging;
using PKHeX.Avalonia.Sprites;

namespace PKHeX.Avalonia.ViewModels;

/// <summary>An entry of the move selectors: display text, move id, type and legality for the current entity.</summary>
public sealed record MoveChoice(string Text, int Value, bool IsIllegal, byte Type)
{
    public bool HasType => Value != 0;
    public Bitmap? TypeSprite => HasType ? SpriteService.GetMoveTypeSprite(Type) : null;
}
