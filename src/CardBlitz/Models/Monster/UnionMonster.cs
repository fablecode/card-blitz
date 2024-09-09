using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Models.Monster;

public sealed class UnionMonster : IMonsterSubtype
{
    public string Name => MonsterSubtype.Union;
}