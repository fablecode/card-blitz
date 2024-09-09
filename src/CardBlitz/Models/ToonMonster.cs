using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Models;

public sealed class ToonMonster : IMonsterSubtype
{
    public string Name => MonsterSubtype.Toon;
}