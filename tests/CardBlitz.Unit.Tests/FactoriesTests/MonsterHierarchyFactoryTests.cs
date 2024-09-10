using CardBlitz.Domain.Monster;
using CardBlitz.Factories;
using FluentAssertions;
using NUnit.Framework;

namespace CardBlitz.Unit.Tests.FactoriesTests;

[TestFixture]
public class MonsterHierarchyFactoryTests
{
    [Test]
    public void Given_An_Invalid_Level_Rank_And_LinkRating_Should_Throw_Argument_Exception()
    {
        // Arrange
        const int level = 0;
        const int rank = 0;
        const int linkRating = 0;

        // Act
        Action act = () => MonsterHierarchyFactory.CreateMonsterHierarchy(level, rank, linkRating);

        // Assert
        act.Should().Throw<ArgumentException>();
    }

    [Test]
    public void Given_A_Level_A_Rank_And_A_LinkRating_If_More_Than_One_Has_A_Value_Greater_Than_Zero_Should_Throw_Argument_Exception()
    {
        // Arrange
        const int level = 1;
        const int rank = 1;
        const int linkRating = 0;

        // Act
        Action act = () => MonsterHierarchyFactory.CreateMonsterHierarchy(level, rank, linkRating);

        // Assert
        act.Should().Throw<ArgumentException>();
    }

    [Test]
    public void Given_A_Valid_Level_Should_Return_Level_Type()
    {
        // Arrange
        const int level = 4;
        const int rank = 0;
        const int linkRating = 0;

        // Act
        var result = MonsterHierarchyFactory.CreateMonsterHierarchy(level, rank, linkRating);

        // Assert
        result.Should().BeOfType<Level>();
    }

    [Test]
    public void Given_A_Valid_Level_Should_Return_Level_Type_With_The_Correct_Value()
    {
        // Arrange
        const int expected = 4; 

        const int level = 4;
        const int rank = 0;
        const int linkRating = 0;

        // Act
        var result = MonsterHierarchyFactory.CreateMonsterHierarchy(level, rank, linkRating);

        // Assert
        result.Value.Should().Be(expected);
    }

    [Test]
    public void Given_A_Valid_Rank_Should_Return_Rank_Type()
    {
        // Arrange
        const int level = 0;
        const int rank = 7;
        const int linkRating = 0;

        // Act
        var result = MonsterHierarchyFactory.CreateMonsterHierarchy(level, rank, linkRating);

        // Assert
        result.Should().BeOfType<Rank>();
    }

    [Test]
    public void Given_A_Valid_Rank_Should_Return_Rank_Type_With_The_Correct_Value()
    {
        // Arrange
        const int expected = 7; 

        const int level = 0;
        const int rank = 7;
        const int linkRating = 0;

        // Act
        var result = MonsterHierarchyFactory.CreateMonsterHierarchy(level, rank, linkRating);

        // Assert
        result.Value.Should().Be(expected);
    }

    [Test]
    public void Given_A_Valid_LinkRating_Should_Return_LinkRating_Type()
    {
        // Arrange
        const int level = 0;
        const int rank = 0;
        const int linkRating = 6;

        // Act
        var result = MonsterHierarchyFactory.CreateMonsterHierarchy(level, rank, linkRating);

        // Assert
        result.Should().BeOfType<LinkRating>();
    }

    [Test]
    public void Given_A_Valid_LinkRating_Should_Return_LinkRating_Type_With_The_Correct_Value()
    {
        // Arrange
        const int expected = 6; 

        const int level = 0;
        const int rank = 0;
        const int linkRating = 6;

        // Act
        var result = MonsterHierarchyFactory.CreateMonsterHierarchy(level, rank, linkRating);

        // Assert
        result.Value.Should().Be(expected);
    }
}