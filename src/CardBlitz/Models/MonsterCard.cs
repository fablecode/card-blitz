using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Models;

public sealed class MonsterCard : ICardType
{
    public MonsterCard(string name, MonsterAttribute attribute, MonsterType type, IEnumerable<IMonsterSubtype> subTypes)
    {
        Name = name; 
        Attribute = attribute;
        Type = type;
        SubTypes = subTypes;
    }

    public string Name { get; }
    public MonsterAttribute Attribute { get; }
    public MonsterType Type { get; }
    public IEnumerable<IMonsterSubtype> SubTypes { get; }
}