using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Models;

public sealed class XyzMonster : IMonsterSubtype
{
    public XyzMonster(string materials)
    {
        Materials = materials;
    }

    public string Name => MonsterSubtype.Xyz;
    public string Materials { get; }
}