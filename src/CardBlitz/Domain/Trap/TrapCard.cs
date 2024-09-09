using CardBlitz.Core;

namespace CardBlitz.Domain.Trap;

public sealed class TrapCard(string name, TrapType type) : ICardType
{
    public string Name { get; } = name;
    public TrapType Type { get; } = type;
}