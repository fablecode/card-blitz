using CardBlitz.Constants;
using CardBlitz.Core;
using CardBlitz.Models.Trap;

namespace CardBlitz.Models;

public sealed class TrapCard(string name, TrapType type) : ICardType
{
    public string Name { get; } = name;
    public TrapType Type { get; } = type;
}