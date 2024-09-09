using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Domain.Monster;

public sealed class FlipMonster : IMonsterSubtype
{
    public string Name => MonsterSubtype.Flip;
}