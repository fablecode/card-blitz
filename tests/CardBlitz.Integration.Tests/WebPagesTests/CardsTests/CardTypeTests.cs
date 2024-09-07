using CardBlitz.WebPages.Cards;
using FluentAssertions;
using NUnit.Framework;

namespace CardBlitz.Integration.Tests.WebPagesTests.CardsTests;

[TestFixture]
public class CardTypeTests
{
    private CardHtmlDocument _sut = null!;

    [SetUp]
    public void SetUp()
    {
        _sut = new CardHtmlDocument(new CardHtmlTable());
    }

    [TestCase("https://yugioh.fandom.com/wiki/4-Starred_Ladybug_of_Doom", "Monster")]
    [TestCase("https://yugioh.fandom.com/wiki/Monster_Reborn", "Spell")]
    public void Given_A_Card_Profile_WebPage_Url_Should_Extract_Card_Type(string url, string expected)
    {
        // Arrange
        var htmlWebPage = new HtmlWebPage();
        var htmlDocument = htmlWebPage.Load(url);

        // Act
        var result = _sut.CardType(htmlDocument);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}