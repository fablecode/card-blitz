using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Models;

public sealed class TunerMonster : IMonsterSubtype
{
    public string Name => MonsterSubtype.Tuner;
}