using CardBlitz.WebPages.Cards;
using FluentAssertions;
using NUnit.Framework;

namespace CardBlitz.Integration.Tests.WebPagesTests.CardsTests;

[TestFixture]
public class DescriptionTests
{
    private CardHtmlDocument _sut = null!;

    [SetUp]
    public void SetUp()
    {
        _sut = new CardHtmlDocument(new CardHtmlTable());
    }

    [TestCase("https://yugioh.fandom.com/wiki/4-Starred_Ladybug_of_Doom",
        "FLIP: Destroy all Level 4 monsters your opponent controls.")]
    [TestCase("https://yugioh.fandom.com/wiki/Blue-Eyes_White_Dragon",
        "This legendary dragon is a powerful engine of destruction. Virtually invincible, very few have faced this awesome creature and lived to tell the tale.")]
    [TestCase("https://yugioh.fandom.com/wiki/Odd-Eyes_Pendulumgraph_Dragon",
        "You can Ritual Summon this card with \"Odd-Eyes Advent\". Must be either Ritual Summoned, or Pendulum Summoned from your hand. Each time your opponent Special Summons a monster(s) from the Extra Deck, inflict 300 damage to them. Once per turn, when your opponent activates a Spell Card or effect (Quick Effect): You can place this card in your Pendulum Zone, and if you do, negate that effect, then, if you placed this Ritual Summoned card in the Pendulum Zone, you can Special Summon 1 \"Odd-Eyes\" monster from your Extra Deck.")]
    public void Given_A_Card_Profile_WebPage_Url_Should_Extract_Card_Description(string url, string expected)
    {
        // Arrange
        var htmlWebPage = new HtmlWebPage();
        var htmlDocument = htmlWebPage.Load(url);

        // Act
        var result = _sut.Description(htmlDocument);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}