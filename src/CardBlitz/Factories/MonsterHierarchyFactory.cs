using CardBlitz.Core;
using CardBlitz.Domain.Monster;

namespace CardBlitz.Factories;

public class MonsterHierarchyFactory
{
    public static IMonsterHierarchy CreateMonsterHierarchy(int level, int rank, int linkRating)
    {
        var nonZeroValues = new[] { level, rank, linkRating }.Where(value => value > 0).ToList();

        if (!nonZeroValues.Any())
        {
            throw new ArgumentException("At least one of Level, Rank, or Link Rating must have a non-zero value.");
        }

        if (nonZeroValues.Count > 1)
        {
            throw new ArgumentException("A monster can only have one of Level, Rank, or Link Rating.");
        }

        return level > 0 ? new Level(level) :
            rank > 0 ? new Rank(rank) :
            linkRating > 0 ? new LinkRating(linkRating) :
            throw new ArgumentException("Level, Rank, or Link Rating must have a valid value.");
    }
}