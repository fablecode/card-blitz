using CardBlitz.Domain.Monster;
using CardBlitz.Domain.Spell;
using CardBlitz.Domain.Trap;
using CardBlitz.Factories;
using CardBlitz.WebPages;
using FluentAssertions;
using NUnit.Framework;

namespace CardBlitz.Unit.Tests.FactoriesTests.CardTypeFactoryTests;

[TestFixture]
public class CreateCardTypeTests
{
    [TestCaseSource(nameof(CreateMonsterSubtypesCases))]
    public void Given_A_YugiohWebPageCard_Should_Return_A_Card_Type(YugiohWebPageCard yugiohWebPageCard, Type expected)
    {
        // Arrange
        // Act
        var result = CardTypeFactory.CreateCardType(yugiohWebPageCard);

        // Assert
        result.Should().BeOfType(expected);
    }

    [Test]
    public void Given_A_YugiohWebPageCard_With_An_Unknown_CardType_Should_Throw_ArgumentException()
    {
        // Arrange
        var yugiohWebPageCard = new YugiohWebPageCard { Name = "Monster Reborn", CardType = "Unknown", Types = "Effect" };

        // Act
        Action act = () => CardTypeFactory.CreateCardType(yugiohWebPageCard);

        // Assert
        act.Should().Throw<ArgumentException>();
    }

    #region Test Data
    private static IEnumerable<TestCaseData> CreateMonsterSubtypesCases()
    {
        yield return new TestCaseData(new YugiohWebPageCard
        {
            Name = "Odd-Eyes Pendulumgraph Dragon", 
            Level = 7, 
            CardType = "Monster", 
            Description = "Pendulum Effect: During the End Phase: You can add 1 Ritual Spell from your Deck or GY to your hand, then return this card to the hand. You can only use this effect of \"Odd-Eyes Pendulumgraph Dragon\" once per turn.\r\nMonster Effect: You can Ritual Summon this card with \"Odd-Eyes Advent\". Must be either Ritual Summoned, or Pendulum Summoned from your hand. Each time your opponent Special Summons a monster(s) from the Extra Deck, inflict 300 damage to them. Once per turn, when your opponent activates a Spell Card or effect (Quick Effect): You can place this card in your Pendulum Zone, and if you do, negate that effect, then, if you placed this Ritual Summoned card in the Pendulum Zone, you can Special Summon 1 \"Odd-Eyes\" monster from your Extra Deck.",
            Types = "Dragon / Ritual / Pendulum / Effect",
            AtkDef = "2700 / 2500"
        }, typeof(MonsterCard));
        yield return new TestCaseData(new YugiohWebPageCard { Name = "Monster Reborn", CardType = "Spell", Types = "Effect" }, typeof(SpellCard));
        yield return new TestCaseData(new YugiohWebPageCard { Name = "Call of the haunted", CardType = "Trap", Types = "Effect" }, typeof(TrapCard));
    }
    #endregion

}