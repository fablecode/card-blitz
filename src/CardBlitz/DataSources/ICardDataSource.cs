namespace CardBlitz.DataSources;

public interface ICardDataSource
{
    Card GetCardByName(string name);
    Card GetCardByPasscode(long passcode);
}