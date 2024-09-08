using CardBlitz.DataSources;
using CardBlitz.WebPages.Cards;
using FluentAssertions;
using NUnit.Framework;

namespace CardBlitz.Integration.Tests.DataSourcesTests
{
    [TestFixture]
    public class CardByNameTests
    {
        private WikiDataSource _cardDataSouce;

        [SetUp]
        public void SetUp()
        {
            _cardDataSouce = new WikiDataSource(new CardWebPage(new CardHtmlDocument(new CardHtmlTable()), new HtmlWebPage()));
        }

        [TestCase("Odd-Eyes Pendulumgraph Dragon", 66425726)]
        public void Given_A_Card_Name_Should_Return_Card_Id_From_Data_Source(string cardName, long expected)
        {
            // Arrange

            // Act
            var result = _cardDataSouce.CardByName(cardName);

            // Assert
            result.Id.Should().Be(expected);
        }

        [TestCase("Odd-Eyes Pendulumgraph Dragon", "Odd-Eyes Pendulumgraph Dragon")]
        public void Given_A_Card_Name_Should_Return_Card_Name_From_Data_Source(string cardName, string expected)
        {
            // Arrange

            // Act
            var result = _cardDataSouce.CardByName(cardName);

            // Assert
            result.CardType.Name.Should().BeEquivalentTo(expected);
        }
    }
}
