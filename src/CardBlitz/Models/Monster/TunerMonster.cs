using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Models.Monster;

public sealed class TunerMonster : IMonsterSubtype
{
    public string Name => MonsterSubtype.Tuner;
}