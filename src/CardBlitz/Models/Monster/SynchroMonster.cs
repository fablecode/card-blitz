using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Models.Monster;

public sealed class SynchroMonster : IMonsterSubtype
{
    public SynchroMonster(string materials)
    {
        Materials = materials;
    }

    public string Name => MonsterSubtype.Synchro;
    public string Materials { get; }
}