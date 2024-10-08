﻿using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Domain.Monster;

public sealed class NormalMonster : IMonsterSubtype
{
    public NormalMonster(string description)
    {
        Description = description;
    }

    public string Name => MonsterSubtype.Normal;
    public string Description { get; }
}