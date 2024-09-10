using CardBlitz.Constants;
using CardBlitz.Core;
using CardBlitz.Domain;
using CardBlitz.Domain.Monster;
using CardBlitz.Domain.Spell;
using CardBlitz.Domain.Trap;
using CardBlitz.WebPages;

namespace CardBlitz.Factories;

public static class CardTypeFactory
{
    public static ICardType CreateCardType(YugiohWebPageCard yugiohWebPageCard)
    {
        switch (yugiohWebPageCard.CardType)
        {
            case CardType.Monster:
                var monsterAttribute = MonsterAttributeFactory.CreateMonsterAttribute(yugiohWebPageCard.Attribute);
                var monsterHierarchy = MonsterHierarchyFactory.CreateMonsterHierarchy(yugiohWebPageCard.Level.GetValueOrDefault(), yugiohWebPageCard.Rank.GetValueOrDefault(), yugiohWebPageCard.MonsterLinkArrows.Length);
                var monsterType = MonsterTypeFactory.CreateMonsterType(yugiohWebPageCard.MonsterSubCategoriesAndTypes);
                var monsterSubtypes = MonsterSubtypeFactory.CreateMonsterSubtypes(yugiohWebPageCard);
                var monsterStats = MonsterStatsFactory.CreateMonsterStats(yugiohWebPageCard);

                return new MonsterCard
                (
                    yugiohWebPageCard.Name,
                    monsterHierarchy,
                    monsterAttribute,
                    monsterType,
                    monsterSubtypes,
                    monsterStats
                );
            case CardType.Spell:
                return new SpellCard(yugiohWebPageCard.Name, SpellTypeFactory.CreateSpellType(yugiohWebPageCard.CardType));
            case CardType.Trap:
                return new TrapCard(yugiohWebPageCard.Name, TrapTypeFactory.CreateTrapType(yugiohWebPageCard.CardType));
            default:
                throw new ArgumentOutOfRangeException(nameof(yugiohWebPageCard.CardType));
        }
    }
}