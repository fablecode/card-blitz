using CardBlitz.Constants;
using CardBlitz.Core;
using CardBlitz.Domain.Monster;
using CardBlitz.WebPages;
using System.Collections.Immutable;

namespace CardBlitz.Factories;

public static class MonsterSubtypeFactory
{
    public static IEnumerable<IMonsterSubtype> CreateMonsterSubtypes(YugiohWebPageCard yugiohWebPageCard)
    {
        var monsterSubtypes = new List<IMonsterSubtype>();

        foreach (var monsterSubtype in GetMonsterSubtypes(yugiohWebPageCard.MonsterSubCategoriesAndTypes))
        {
            switch (monsterSubtype)
            {
                case MonsterSubtype.Normal:
                    monsterSubtypes.Add(new NormalMonster(yugiohWebPageCard.Description));
                    break;
                case MonsterSubtype.Effect:
                    monsterSubtypes.Add(new EffectMonster(yugiohWebPageCard.Description));
                    break;
                case MonsterSubtype.Fusion:
                    monsterSubtypes.Add(new FusionMonster(yugiohWebPageCard.Materials));
                    break;
                case MonsterSubtype.Ritual:
                    monsterSubtypes.Add(new RitualMonster());
                    break;
                case MonsterSubtype.Synchro:
                    monsterSubtypes.Add(new SynchroMonster(yugiohWebPageCard.Materials));
                    break;
                case MonsterSubtype.Xyz:
                    monsterSubtypes.Add(new XyzMonster(yugiohWebPageCard.Rank.GetValueOrDefault(), yugiohWebPageCard.Materials));
                    break;
                case MonsterSubtype.Pendulum:
                    monsterSubtypes.Add(new PendulumMonster(yugiohWebPageCard.PendulumScale.GetValueOrDefault(), yugiohWebPageCard.Description));
                    break;
                case MonsterSubtype.Tuner:
                    monsterSubtypes.Add(new TunerMonster());
                    break;
                case MonsterSubtype.Gemini:
                    monsterSubtypes.Add(new GeminiMonster());
                    break;
                case MonsterSubtype.Union:
                    monsterSubtypes.Add(new UnionMonster());
                    break;
                case MonsterSubtype.Spirit:
                    monsterSubtypes.Add(new SpiritMonster());
                    break;
                case MonsterSubtype.Flip:
                    monsterSubtypes.Add(new FlipMonster());
                    break;
                case MonsterSubtype.Toon:
                    monsterSubtypes.Add(new ToonMonster());
                    break;
                case MonsterSubtype.Link:
                    monsterSubtypes.Add(new LinkMonster(yugiohWebPageCard.MonsterLinkArrows));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(monsterSubtype));
            }
        }

        return monsterSubtypes.ToImmutableArray();
    }

    public static IEnumerable<string> GetMonsterSubtypes(string[] monsterSubCategoriesAndTypes)
    {
        return monsterSubCategoriesAndTypes.Skip(1);
    }
}