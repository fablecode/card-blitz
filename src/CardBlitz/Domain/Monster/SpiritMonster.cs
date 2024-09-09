using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Domain.Monster;

public sealed class SpiritMonster : IMonsterSubtype
{
    public string Name => MonsterSubtype.Spirit;
}