using CardBlitz.Domain;
using HtmlAgilityPack;

namespace CardBlitz.WebPages;

public interface ICardWebPage
{
    YugiohWebPageCard GetYugiohCard(string url);
    YugiohWebPageCard GetYugiohCard(Uri url);
    YugiohWebPageCard GetYugiohCard(HtmlDocument htmlDocument);
}