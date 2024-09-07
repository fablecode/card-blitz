using CardBlitz.DataSources;
using CardBlitz.Models;
using NUnit.Framework;

namespace CardBlitz.Integration.Tests.DataSourcesTests
{
    [TestFixture]
    public class CardByNameTests
    {
        [SetUp]
        public void SetUp()
        {
            var datasource = new WikiDataSource();
        }

        [TestCase("Odd-Eyes Pendulumgraph Dragon")]
        public void Given_A_Card_Name_Should_Return_Card_Name_From_Data_Source(string cardName)
        {
            // Arrange
            // Act
            // Assert
        }
    }

    public class WikiDataSource : ICardDataSource
    {
        public Card CardByName(string name)
        {
            throw new NotImplementedException();
        }

        public Card CardByPasscode(long passcode)
        {
            throw new NotImplementedException();
        }
    }
}
