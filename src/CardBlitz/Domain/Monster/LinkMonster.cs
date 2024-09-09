using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Domain.Monster;

public sealed class LinkMonster(IReadOnlyCollection<string> linkArrows) : IMonsterSubtype
{
    public string Name => MonsterSubtype.Link;

    public int LinkRating { get; } = linkArrows.Count;
    public IEnumerable<string> LinkArrows { get; } = linkArrows;
}