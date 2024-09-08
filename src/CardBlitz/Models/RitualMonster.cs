using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Models;

public sealed class RitualMonster : IMonsterSubtype
{
    public string Name => MonsterSubtype.Ritual;
    public int RitualSpellCard { get; set; }
}