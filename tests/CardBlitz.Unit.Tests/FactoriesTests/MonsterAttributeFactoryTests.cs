using CardBlitz.Factories;
using FluentAssertions;
using NUnit.Framework;

namespace CardBlitz.Unit.Tests.FactoriesTests;

[TestFixture]
public class MonsterAttributeFactoryTests
{
    [TestCase("Light", "Light")]
    public void Given_An_Attribute_Should_Create_A_Monster_Attribute_Type_With_The_Correct_Name(string attribute, string expected)
    {
        // Arrange
        // Act
        var result = MonsterAttributeFactory.CreateMonsterAttribute(attribute);

        // Assert
        result.Name.Should().BeEquivalentTo(expected);
    }
}