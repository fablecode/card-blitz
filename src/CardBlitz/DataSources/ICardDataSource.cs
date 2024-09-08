using CardBlitz.Models;

namespace CardBlitz.DataSources;

public interface ICardDataSource
{
    ICard CardByName(string name);
    ICard CardByPasscode(long passcode);
}