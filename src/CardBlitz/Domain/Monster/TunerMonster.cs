using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Domain.Monster;

public sealed class TunerMonster : IMonsterSubtype
{
    public string Name => MonsterSubtype.Tuner;
}