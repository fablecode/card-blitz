using CardBlitz.Models;
using CardBlitz.WebPages.Cards;
using HtmlAgilityPack;

namespace CardBlitz.WebPages;

public interface ICardWebPage
{
    YugiohWebPageCard GetYugiohCard(string url);
    YugiohWebPageCard GetYugiohCard(Uri url);
    YugiohWebPageCard GetYugiohCard(HtmlDocument htmlDocument);
}