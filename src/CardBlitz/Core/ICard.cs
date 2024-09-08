namespace CardBlitz.Core;

public interface ICard
{
    long Id { get; }
    ICardType CardType { get; }
}