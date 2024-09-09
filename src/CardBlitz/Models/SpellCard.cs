using CardBlitz.Constants;
using CardBlitz.Core;
using CardBlitz.Models.Spell;

namespace CardBlitz.Models;

public sealed class SpellCard(string name, SpellType type) : ICardType
{
    public string Name { get; } = name;
    public SpellType Type { get; } = type;
}