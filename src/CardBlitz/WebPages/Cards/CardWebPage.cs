using CardBlitz.Models;
using HtmlAgilityPack;

namespace CardBlitz.WebPages.Cards;

public class CardWebPage : ICardWebPage
{
    private readonly ICardHtmlDocument _cardHtmlDocument;
    private readonly IHtmlWebPage _htmlWebPage;

    public CardWebPage(ICardHtmlDocument cardHtmlDocument, IHtmlWebPage htmlWebPage)
    {
        _cardHtmlDocument = cardHtmlDocument;
        _htmlWebPage = htmlWebPage;
    }

    //public ArticleProcessed GetYugiohCard(Article article)
    //{
    //    var card = GetYugiohCard(article.Url);

    //    return new ArticleProcessed { Article = article, Card = card };
    //}

    public YugiohWebPageCard GetYugiohCard(string url)
    {
        return GetYugiohCard(new Uri(url));
    }

    public YugiohWebPageCard GetYugiohCard(Uri url)
    {
        var htmlDocument = _htmlWebPage.Load(url);
        return GetYugiohCard(htmlDocument);
    }

    public YugiohWebPageCard GetYugiohCard(HtmlDocument htmlDocument)
    {
        var yugiohCard = new YugiohWebPageCard
        {
            ImageUrl = _cardHtmlDocument.ImageUrl(htmlDocument),
            Name = _cardHtmlDocument.Name(htmlDocument),
            Description = _cardHtmlDocument.Description(htmlDocument),
            CardNumber = _cardHtmlDocument.CardNumber(htmlDocument),
            CardType = _cardHtmlDocument.CardType(htmlDocument),
            Property = _cardHtmlDocument.Property(htmlDocument),
            Attribute = _cardHtmlDocument.Attribute(htmlDocument),
            Level = _cardHtmlDocument.Level(htmlDocument),
            Rank = _cardHtmlDocument.Rank(htmlDocument),
            AtkDef = _cardHtmlDocument.AtkDef(htmlDocument),
            AtkLink = _cardHtmlDocument.AtkLink(htmlDocument),
            Types = _cardHtmlDocument.Types(htmlDocument),
            Materials = _cardHtmlDocument.Materials(htmlDocument),
            CardEffectTypes = _cardHtmlDocument.CardEffectTypes(htmlDocument),
            PendulumScale = _cardHtmlDocument.PendulumScale(htmlDocument),
        };

        return yugiohCard;
    }

}