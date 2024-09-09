using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Models.Monster;

public sealed class XyzMonster : IMonsterSubtype
{
    public XyzMonster(int rank, string materials)
    {
        Rank = rank;
        Materials = materials;
    }

    public string Name => MonsterSubtype.Xyz;
    public int Rank { get; }
    public string Materials { get; }
}