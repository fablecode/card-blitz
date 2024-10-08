﻿using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Domain.Monster;

public sealed class FusionMonster : IMonsterSubtype
{
    public FusionMonster(string materials)
    {
        Materials = materials;
    }

    public string Name => MonsterSubtype.Fusion;
    public string Materials { get; }
}