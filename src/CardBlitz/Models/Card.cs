using CardBlitz.Core;

namespace CardBlitz.Models;

public sealed class Card(long id, ICardType cardType) : ICard
{
    public long Id { get; } = id;
    public ICardType CardType { get; } = cardType;
}