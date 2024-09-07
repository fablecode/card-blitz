using CardBlitz.WebPages.Cards;
using FluentAssertions;
using NUnit.Framework;

namespace CardBlitz.Integration.Tests.WebPagesTests.CardsTests;

[TestFixture]
public class NameTests
{
    private CardHtmlDocument _sut = null!;

    [SetUp]
    public void SetUp()
    {
        _sut = new CardHtmlDocument(new CardHtmlTable());
    }

    [TestCase("https://yugioh.fandom.com/wiki/4-Starred_Ladybug_of_Doom", "4-Starred Ladybug of Doom")]
    [TestCase("https://yugioh.fandom.com/wiki/Blue-Eyes_White_Dragon", "Blue-Eyes White Dragon")]
    [TestCase("https://yugioh.fandom.com/wiki/Odd-Eyes_Pendulumgraph_Dragon", "Odd-Eyes Pendulumgraph Dragon")]
    public void Given_A_Card_Profile_WebPage_Url_Should_Extract_Card_Name(string url, string expected)
    {
        // Arrange
        var htmlWebPage = new HtmlWebPage();
        var htmlDocument = htmlWebPage.Load(url);

        // Act
        var result = _sut.Name(htmlDocument);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}