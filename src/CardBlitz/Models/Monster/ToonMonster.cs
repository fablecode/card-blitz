using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Models.Monster;

public sealed class ToonMonster : IMonsterSubtype
{
    public string Name => MonsterSubtype.Toon;
}