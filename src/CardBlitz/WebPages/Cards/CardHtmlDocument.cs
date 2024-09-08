using System.Text.RegularExpressions;
using CardBlitz.Helpers;
using HtmlAgilityPack;

namespace CardBlitz.WebPages.Cards;

public class CardHtmlDocument : ICardHtmlDocument
{
    private readonly ICardHtmlTable _cardHtmlTable;

    public CardHtmlDocument(ICardHtmlTable cardHtmlTable)
    {
        _cardHtmlTable = cardHtmlTable;
    }

    public string ImageUrl(HtmlDocument htmlDocument)
    {
        var imageUrl = htmlDocument.DocumentNode.SelectSingleNode("//td[@class='cardtable-cardimage']/a/img")?.Attributes["src"]?.Value;

        return ImageHelper.ExtractImageUrl(imageUrl);
    }

    public string Name(HtmlDocument htmlDocument)
    {
        var htmlTableNode = ExtractHtmlCardTableNode(htmlDocument);

        return _cardHtmlTable.GetValue(CardHtmlTable.Name, htmlTableNode);
    }

    public string Description(HtmlDocument htmlDocument)
    {
        const string pattern = @"(?!</?br>)<.*?>";
        var descNode = htmlDocument.DocumentNode.SelectSingleNode("//b[text()[contains(., 'Card descriptions')]]/../table[1]/tbody/tr[1]/td[1]/table[1]/tbody/tr[3]/td")?.InnerHtml;

        if (descNode != null)
        {
            descNode = Regex.Replace(descNode, pattern, string.Empty, RegexOptions.Multiline);

            return descNode.Trim();
        }

        return string.Empty;
    }

    public string CardNumber(HtmlDocument htmlDocument)
    {
        return ExtractHtmlCardTableValue(CardHtmlTable.Number, htmlDocument);
    }

    public string CardType(HtmlDocument htmlDocument)
    {
        return ExtractHtmlCardTableValue(CardHtmlTable.CardType, htmlDocument);
    }

    public string Property(HtmlDocument htmlDocument)
    {
        return ExtractHtmlCardTableValue(CardHtmlTable.Property, htmlDocument);
    }

    public string Attribute(HtmlDocument htmlDocument)
    {
        var attribute = ExtractHtmlCardTableValue(CardHtmlTable.Attribute, htmlDocument);

        if (string.IsNullOrWhiteSpace(attribute))
            return string.Empty;

        var cultureInfo = Thread.CurrentThread.CurrentCulture;
        var textInfo = cultureInfo.TextInfo;

        return textInfo.ToTitleCase(attribute.Trim().ToLower());

    }

    public int? Level(HtmlDocument htmlDocument)
    {
        var level = ExtractHtmlCardTableValue(CardHtmlTable.Level, htmlDocument);
        return int.TryParse(level, out var cardLevel) ? cardLevel : null;
    }

    public int? Rank(HtmlDocument htmlDocument)
    {
        var rank = ExtractHtmlCardTableValue(CardHtmlTable.Rank, htmlDocument);
        return int.TryParse(rank, out var cardRank) ? cardRank : null;
    }

    public string AtkDef(HtmlDocument htmlDocument)
    {
        return ExtractHtmlCardTableValue(CardHtmlTable.AtkAndDef, htmlDocument);
    }

    public string AtkLink(HtmlDocument htmlDocument)
    {
        return ExtractHtmlCardTableValue(CardHtmlTable.AtkAndLink, htmlDocument);
    }

    public string LinkArrows(HtmlDocument htmlDocument)
    {
        return ExtractHtmlCardTableValue(CardHtmlTable.LinkArrows, htmlDocument);
    }

    public string Types(HtmlDocument htmlDocument)
    {
        return ExtractHtmlCardTableValue(CardHtmlTable.Types, htmlDocument);
    }

    public string Materials(HtmlDocument htmlDocument)
    {
        return ExtractHtmlCardTableValue(CardHtmlTable.Materials, htmlDocument);
    }

    public string CardEffectTypes(HtmlDocument htmlDocument)
    {
        return ExtractHtmlCardTableValue(CardHtmlTable.CardEffectTypes, htmlDocument);
    }

    public int? PendulumScale(HtmlDocument htmlDocument)
    {
        var scale = ExtractHtmlCardTableValue(CardHtmlTable.PendulumScale, htmlDocument);
        return int.TryParse(scale, out var cardScale) ? cardScale : null;

    }

    public string PendulumEffect(HtmlDocument htmlDocument)
    {
        var description = RemoveHtmlTags(Description(htmlDocument));

        // Define regex pattern to extract Pendulum Effect
        string pattern = @"Pendulum Effect:(.*?)(?=Monster Effect|$)";

        // Use regular expression to find the pendulum effect text
        Match match = Regex.Match(description, pattern, RegexOptions.Singleline);

        // Return the captured group (Pendulum Effect)
        return match.Success ? match.Groups[1].Value.Trim() : string.Empty;
    }

    #region private helpers

    private static HtmlNode ExtractHtmlCardTableNode(HtmlDocument htmlDocument)
    {
        return htmlDocument.DocumentNode.SelectSingleNode("//table[contains(@class, 'cardtable')]");
    }

    private string ExtractHtmlCardTableValue(string key, HtmlDocument htmlDocument)
    {
        return ExtractHtmlCardTableValue(new[] { key }, htmlDocument);
    }

    private string ExtractHtmlCardTableValue(string[] key, HtmlDocument htmlDocument)
    {
        var htmlTableNode = ExtractHtmlCardTableNode(htmlDocument);
        return _cardHtmlTable.GetValue(key, htmlTableNode);
    }

    public static string RemoveHtmlTags(string input)
    {
        // Define regex pattern to match HTML tags (anything between < and >)
        string pattern = @"<[^>]+>";

        // Use Regex.Replace to remove all HTML tags
        string result = Regex.Replace(input, pattern, string.Empty);

        return result;
    }

    #endregion
}