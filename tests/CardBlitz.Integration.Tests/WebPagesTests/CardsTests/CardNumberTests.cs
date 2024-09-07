using CardBlitz.WebPages.Cards;
using FluentAssertions;
using NUnit.Framework;

namespace CardBlitz.Integration.Tests.WebPagesTests.CardsTests;

[TestFixture]
public class CardNumberTests
{
    private CardHtmlDocument _sut = null!;

    [SetUp]
    public void SetUp()
    {
        _sut = new CardHtmlDocument(new CardHtmlTable());
    }

    [TestCase("https://yugioh.fandom.com/wiki/Odd-Eyes_Pendulumgraph_Dragon", "66425726")]
    [TestCase("https://yugioh.fandom.com/wiki/Blue-Eyes_White_Dragon", "89631139")]
    public void Given_A_Card_Profile_WebPage_Url_Should_Extract_Card_Number(string url, string expected)
    {
        // Arrange
        var htmlWebPage = new HtmlWebPage();
        var htmlDocument = htmlWebPage.Load(url);

        // Act
        var result = _sut.CardNumber(htmlDocument);

        // Assert
        result.Should().BeEquivalentTo(expected);
    }
}