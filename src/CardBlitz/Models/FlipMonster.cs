using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Models;

public sealed class FlipMonster : IMonsterSubtype
{
    public string Name => MonsterSubtype.Flip;
}