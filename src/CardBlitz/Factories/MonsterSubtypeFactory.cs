using System.Collections.Immutable;
using CardBlitz.Constants;
using CardBlitz.Models;

namespace CardBlitz.Factories;

public static class MonsterSubtypeFactory
{
    public static IEnumerable<IMonsterSubtype> CreateMonsterSubtypes(YugiohWebPageCard yugiohWebPageCard)
    {
        var monsterSubtypes = new List<IMonsterSubtype>();

        foreach (var monsterSubtype in yugiohWebPageCard.MonsterSubCategoriesAndTypes.Skip(1))
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
                    monsterSubtypes.Add(new XyzMonster(yugiohWebPageCard.Materials));
                    break;
                case MonsterSubtype.Pendulum:
                    monsterSubtypes.Add(new PendulumMonster(yugiohWebPageCard.PendulumScale.GetValueOrDefault(), yugiohWebPageCard.PendulumEffect));
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(monsterSubtype));
            }
        }

        return monsterSubtypes.ToImmutableArray();
    }
}