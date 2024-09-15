using CardBlitz.Factories;
using FluentAssertions;
using NUnit.Framework;

namespace CardBlitz.Unit.Tests.FactoriesTests.MonsterStatsFactoryTests;

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