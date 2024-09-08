using HtmlAgilityPack;

namespace CardBlitz.WebPages;

public interface IHtmlWebPage
{
    HtmlDocument Load(string webPageUrl);
    HtmlDocument Load(Uri webPageUrl);
}