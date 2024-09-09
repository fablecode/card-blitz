using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Models;

public sealed class UnionMonster : IMonsterSubtype
{
    public string Name => MonsterSubtype.Union;
}