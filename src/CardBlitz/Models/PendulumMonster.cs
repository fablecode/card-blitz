using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Models;

public sealed class PendulumMonster : IMonsterSubtype
{
    public PendulumMonster(int scale, string effect)
    {
        Scale = scale;
        Effect = effect;
    }

    public string Name => MonsterSubtype.Pendulum;
    public int Scale { get; }
    public string Effect { get; }
}