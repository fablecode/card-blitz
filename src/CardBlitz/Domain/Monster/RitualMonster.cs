using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Domain.Monster;

public sealed class RitualMonster : IMonsterSubtype
{
    public string Name => MonsterSubtype.Ritual;
    public int RitualSpellCard { get; set; }
}