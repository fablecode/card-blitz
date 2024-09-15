using CardBlitz.Factories;
using FluentAssertions;
using NUnit.Framework;

namespace CardBlitz.Unit.Tests.FactoriesTests.MonsterStatsFactoryTests;

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