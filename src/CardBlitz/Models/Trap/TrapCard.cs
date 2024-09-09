using CardBlitz.Core;

namespace CardBlitz.Models.Trap;

public sealed class TrapCard(string name, TrapType type) : ICardType
{
    public string Name { get; } = name;
    public TrapType Type { get; } = type;
}