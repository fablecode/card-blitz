using CardBlitz.Domain;

namespace CardBlitz.Factories;

public static class CardFactory
{
    public static Card FromYugiohWebPageCard(YugiohWebPageCard yugiohWebPageCard)
    {
        return long.TryParse(yugiohWebPageCard.CardNumber, out var cardNumber)
            ? new Card(cardNumber, CardTypeFactory.CreateCardType(yugiohWebPageCard))
            : new Card(default, CardTypeFactory.CreateCardType(yugiohWebPageCard));
    }
}