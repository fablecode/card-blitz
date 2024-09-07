using CardBlitz.WebPages.Cards;
using FluentAssertions;
using NUnit.Framework;

namespace CardBlitz.Integration.Tests.WebPagesTests.CardsTests;

[TestFixture]
public class CardEffectTypesTests
{
    private CardHtmlDocument _sut = null!;

    [SetUp]
    public void SetUp()
    {
        _sut = new CardHtmlDocument(new CardHtmlTable());
    }

    [TestCase("https://yugioh.fandom.com/wiki/Firewall_Dragon", "Quick,Trigger")]
    [TestCase("https://yugioh.fandom.com/wiki/Odd-Eyes_Pendulumgraph_Dragon", "Trigger-like,Condition,Summon,Summon,Continuous,Quick")]
    public void Given_A_Card_Profile_WebPage_Url_Should_Extract_Card_CardEffectTypes(string url, string expected)
    {
        // Arrange
        var htmlWebPage = new HtmlWebPage();
        var htmlDocument = htmlWebPage.Load(url);

        // Act
        var result = _sut.CardEffectTypes(htmlDocument);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}