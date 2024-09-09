using CardBlitz.Core;

namespace CardBlitz.Models.Spell;

public sealed class SpellCard(string name, SpellType type) : ICardType
{
    public string Name { get; } = name;
    public SpellType Type { get; } = type;
}