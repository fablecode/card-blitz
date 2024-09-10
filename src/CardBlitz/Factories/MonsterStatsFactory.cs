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
            ? new DefensibleStat(Convert.ToInt32(stats.First()), Convert.ToInt32(stats.Last()))
            : new LinkStat(Convert.ToInt32(stats.First()), Convert.ToInt32(stats.Last()));
    }
}