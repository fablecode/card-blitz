﻿using CardBlitz.Core;

namespace CardBlitz.Domain.Monster;

public sealed class MonsterCard : ICardType
{
    public MonsterCard(string name, IMonsterHierarchy hierarchy, MonsterAttribute attribute, MonsterType type, IEnumerable<IMonsterSubtype> subTypes, IMonsterStat monsterStat)
    {
        Name = name;
        Hierarchy = hierarchy;
        Attribute = attribute;
        Type = type;
        SubTypes = subTypes;
        MonsterStat = monsterStat;
    }

    public string Name { get; }
    public IMonsterHierarchy Hierarchy { get; }
    public MonsterAttribute Attribute { get; }
    public MonsterType Type { get; }
    public IEnumerable<IMonsterSubtype> SubTypes { get; }
    public IMonsterStat MonsterStat { get; }
}