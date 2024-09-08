using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Models;

public sealed class NormalMonster : IMonsterSubtype
{
    public NormalMonster(string description)
    {
        Description = description;
    }

    public string Name => MonsterSubtype.Normal;
    public string Description { get; }
}