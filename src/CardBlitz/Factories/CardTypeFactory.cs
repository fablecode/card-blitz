using CardBlitz.Constants;
using CardBlitz.Core;
using CardBlitz.Models;

namespace CardBlitz.Factories;

public static class CardTypeFactory
{
    public static ICardType CreateCardType(YugiohWebPageCard yugiohWebPageCard)
    {
        switch (yugiohWebPageCard.CardType)
        {
            case CardType.Monster:
                var monsterAttribute = MonsterAttributeFactory.CreateMonsterAttribute(yugiohWebPageCard.Attribute);
                var monsterType = MonsterTypeFactory.CreateMonsterType(yugiohWebPageCard.MonsterSubCategoriesAndTypes);
                var monsterSubtypes = MonsterSubtypeFactory.CreateMonsterSubtypes(yugiohWebPageCard);

                return new MonsterCard
                (
                    yugiohWebPageCard.Name,
                    monsterAttribute,
                    monsterType,
                    monsterSubtypes
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