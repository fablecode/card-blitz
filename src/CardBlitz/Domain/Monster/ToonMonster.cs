using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Domain.Monster;

public sealed class ToonMonster : IMonsterSubtype
{
    public string Name => MonsterSubtype.Toon;
}