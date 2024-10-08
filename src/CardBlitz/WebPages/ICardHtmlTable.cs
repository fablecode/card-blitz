﻿using HtmlAgilityPack;

namespace CardBlitz.WebPages;

public interface ICardHtmlTable
{
    string GetValue(string[] keys, HtmlNode htmlTable);
    string GetValue(string key, HtmlNode htmlTable);
    Dictionary<string, string> ProfileData(HtmlNode htmlTable);
}