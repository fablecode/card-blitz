using CardBlitz.Domain;
using CardBlitz.Domain.Monster;
using CardBlitz.Factories;
using CardBlitz.WebPages;
using FluentAssertions;
using NUnit.Framework;

namespace CardBlitz.Unit.Tests.FactoriesTests.MonsterStatsFactoryTests;

[TestFixture]
public class CreateMonsterStatsTests
{
    [Test]
    public void Given_A_YugiohWebPageCard_If_Card_Is_Standard_Return_DefensibleStat_Type()
    {
        // Arrange
        var yugiohWebPageCard = new YugiohWebPageCard();
        yugiohWebPageCard.AtkDef = "3000 / 2500";

        // Act
        var result = MonsterStatsFactory.CreateMonsterStats(yugiohWebPageCard);

        // Assert
        result.Should().BeOfType<DefensibleStat>();
    }
    [Test]
    public void Given_A_YugiohWebPageCard_If_Card_Is_Standard_Return_LinkStat_Type()
    {
        // Arrange
        var yugiohWebPageCard = new YugiohWebPageCard();
        yugiohWebPageCard.AtkDef = "3000 / 4";
        yugiohWebPageCard.LinkArrows = "Top LM-Top, Bottom-Left LM-BottomLeft, Bottom LM-Bottom, Bottom-Right LM-BottomRight";

        // Act
        var result = MonsterStatsFactory.CreateMonsterStats(yugiohWebPageCard);

        // Assert
        result.Should().BeOfType<LinkStat>();
    }
}

[TestFixture]
public class ConvertAtkDefRatingTests
{
    [TestCase("3000", 3000)]
    [TestCase("2500", 2500)]
    [TestCase("?", 0)]
    public void Given_A_Monster_Attack_Or_Defense_Should_Convert_Attack_Or_Defense_To_An_Integer_Value(string atkDef, int expected)
    {
        // Arrange
        // Act
        var result = MonsterStatsFactory.ConvertAtkDef(atkDef);

        // Assert
        result.Should().Be(expected);
    }

    [Test]
    public void Given_An_Invalid_Monster_Attack_Or_Defense_Should_Throw_ArgumentException()
    {
        // Arrange
        const string atkDef = "invalid atk or defence";

        // Act
        Action act = () => MonsterStatsFactory.ConvertAtkDef(atkDef);

        // Assert
        act.Should().Throw<ArgumentException>();
    }
}

[TestFixture]
public class ConvertAtkLinkRatingTests
{
    [TestCase("3000", 3000)]
    [TestCase("4", 4)]
    [TestCase("?", 0)]
    public void Given_A_Monster_Attack_Or_LinkRating_Should_Convert_Attack_Or_LinkRating_To_Integer_Value(string atkLinkRating, int expected)
    {
        // Arrange
        // Act
        var result = MonsterStatsFactory.ConvertAtkLinkRating(atkLinkRating);

        // Assert
        result.Should().Be(expected);
    }

    [Test]
    public void Given_An_Invalid_Monster_Attack_Or_LinkRating_Should_Throw_ArgumentException()
    {
        // Arrange
        const string atkDef = "invalid atk or link rating";

        // Act
        Action act = () => MonsterStatsFactory.ConvertAtkLinkRating(atkDef);

        // Assert
        act.Should().Throw<ArgumentException>();
    }

}