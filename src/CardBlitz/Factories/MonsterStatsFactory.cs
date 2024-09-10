using CardBlitz.Core;
using CardBlitz.Domain;
using CardBlitz.Domain.Monster;

namespace CardBlitz.Factories;

public class MonsterStatsFactory
{
    public static IMonsterStat CreateMonsterStats(YugiohWebPageCard yugiohWebPageCard)
    {
        var stats = yugiohWebPageCard.AtkDef.Split('/');

        return !yugiohWebPageCard.MonsterLinkArrows.Any()
            ? new DefensibleStat(ConvertAtkDef(stats.First()), ConvertAtkDef(stats.Last()))
            : new LinkStat(ConvertAtkLinkRating(stats.First()), ConvertAtkLinkRating(stats.Last()));
    }

    public static int ConvertAtkLinkRating(string atkLinkRating)
    {
        return ConvertStats(atkLinkRating,"Invalid ATK/LinkRating value.");
    }

    public static int ConvertAtkDef(string atkDef)
    {
        return  ConvertStats(atkDef, "Invalid ATK/DEF value.");
    }
    public static int ConvertStats(string monsterStat, string errorMessage)
    {
        // Check if the value is a question mark, indicating an undefined or variable value
        if (monsterStat == "?")
        {
            return 0;  // Return the default value (e.g., 0)
        }

        // Otherwise, attempt to parse the string as an integer
        if (int.TryParse(monsterStat, out var result))
        {
            return result;
        }

        // If parsing fails, throw an exception or handle the error as needed
        throw new ArgumentException(errorMessage, nameof(monsterStat));
    }
}