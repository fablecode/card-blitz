﻿using HtmlAgilityPack;

namespace CardBlitz.WebPages;

public interface ICardHtmlDocument
{
    string ImageUrl(HtmlDocument htmlDocument);
    string Name(HtmlDocument htmlDocument);
    string Description(HtmlDocument htmlDocument);
    string CardNumber(HtmlDocument htmlDocument);
    string CardType(HtmlDocument htmlDocument);
    string Property(HtmlDocument htmlDocument);
    string Attribute(HtmlDocument htmlDocument);
    int? Level(HtmlDocument htmlDocument);
    int? Rank(HtmlDocument htmlDocument);
    string AtkDef(HtmlDocument htmlDocument);
    string AtkLink(HtmlDocument htmlDocument);
    string LinkArrows(HtmlDocument htmlDocument);
    string Types(HtmlDocument htmlDocument);
    string Materials(HtmlDocument htmlDocument);
    string CardEffectTypes(HtmlDocument htmlDocument);
    int? PendulumScale(HtmlDocument htmlDocument);
}