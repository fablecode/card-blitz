using CardBlitz.WebPages.Cards;
using FluentAssertions;
using NUnit.Framework;

namespace CardBlitz.Integration.Tests.WebPagesTests.CardsTests;

[TestFixture]
public class PendulumEffectTests
{
    private CardHtmlDocument _sut = null!;

    [SetUp]
    public void SetUp()
    {
        _sut = new CardHtmlDocument(new CardHtmlTable());
    }

    [TestCase("https://yugioh.fandom.com/wiki/Odd-Eyes_Pendulumgraph_Dragon", "During the End Phase: You can add 1 Ritual Spell from your Deck or GY to your hand, then return this card to the hand. You can only use this effect of \"Odd-Eyes Pendulumgraph Dragon\" once per turn.")]
    public void Given_A_Card_Profile_WebPage_Url_Should_Extract_Card_Description(string url, string expected)
    {
        // Arrange
        var htmlWebPage = new HtmlWebPage();
        var htmlDocument = htmlWebPage.Load(url);

        // Act
        var result = _sut.PendulumEffect(htmlDocument);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}