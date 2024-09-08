using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Models;

public sealed class EffectMonster : IMonsterSubtype
{
    public EffectMonster(string effect)
    {
        Effect = effect;
    }

    public string Name => MonsterSubtype.Effect;
    public string Effect { get; }
}