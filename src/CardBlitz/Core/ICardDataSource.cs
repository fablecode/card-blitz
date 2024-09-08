namespace CardBlitz.Core;

public interface ICardDataSource
{
    ICard CardByName(string name);
    ICard CardByPasscode(long passcode);
}