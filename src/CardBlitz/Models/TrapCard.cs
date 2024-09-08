using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Models;

public sealed class TrapCard(string name, TrapType type) : ICardType
{
    public string Name { get; } = name;
    public TrapType Type { get; } = type;
}