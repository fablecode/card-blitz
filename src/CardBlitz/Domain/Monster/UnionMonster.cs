using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Domain.Monster;

public sealed class UnionMonster : IMonsterSubtype
{
    public string Name => MonsterSubtype.Union;
}