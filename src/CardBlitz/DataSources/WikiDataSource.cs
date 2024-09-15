using CardBlitz.Core;
using CardBlitz.Factories;
using CardBlitz.WebPages;

namespace CardBlitz.DataSources;

public class WikiDataSource : ICardDataSource
{
    private readonly ICardWebPage _cardWebPage;
    public Uri Url => new("https://yugioh.fandom.com");

    public WikiDataSource(ICardWebPage cardWebPage)
    {
        _cardWebPage = cardWebPage;
    }

    public ICard CardByName(string name)
    {
        var yugiohWebPageCard = _cardWebPage.GetYugiohCard(new Uri(Url, $"wiki/{name}"));

        return CardFactory.FromYugiohWebPageCard(yugiohWebPageCard);
    }

    public ICard CardByPasscode(long passcode)
    {
        var yugiohWebPageCard = _cardWebPage.GetYugiohCard(new Uri(Url, $"wiki/{passcode}"));

        return CardFactory.FromYugiohWebPageCard(yugiohWebPageCard);
    }
}