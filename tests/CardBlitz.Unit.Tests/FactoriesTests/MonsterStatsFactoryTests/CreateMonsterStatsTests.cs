﻿using CardBlitz.Domain.Monster;
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