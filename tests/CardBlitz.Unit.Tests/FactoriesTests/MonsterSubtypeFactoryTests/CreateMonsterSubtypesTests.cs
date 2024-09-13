using CardBlitz.Domain.Monster;
using CardBlitz.Factories;
using CardBlitz.WebPages;
using FluentAssertions;
using NUnit.Framework;

namespace CardBlitz.Unit.Tests.FactoriesTests.MonsterSubtypeFactoryTests;

[TestFixture]
public class CreateMonsterSubtypesTests
{
    [TestCaseSource(nameof(CreateMonsterSubtypesCases))]
    public void Given_Monster_Sub_Categories_And_Types_Should_Return_Correct_Monster_Type(YugiohWebPageCard yugiohWebPageCard, Type expected)
    {
        // Arrange
        // Act
        var result = MonsterSubtypeFactory.CreateMonsterSubtypes(yugiohWebPageCard);

        // Assert
        result.Should().ContainSingle(m => m.GetType() == expected);
    }

    [Test]
    public void Given_Monster_Sub_Categories_And_Types_That_Do_Not_Exisit_Should_Throw_ArgumentException()
    {
        // Arrange
        var yugiohWebPageCard = new YugiohWebPageCard { Types = "Unknown / Unknown" };

        // Act
        Action act = () => MonsterSubtypeFactory.CreateMonsterSubtypes(yugiohWebPageCard);

        // Assert
        act.Should().Throw<ArgumentException>();
    }

    #region Test Data
    private static IEnumerable<TestCaseData> CreateMonsterSubtypesCases()
    {
        yield return new TestCaseData(new YugiohWebPageCard { Types = "Dragon / Normal" }, typeof(NormalMonster));
        yield return new TestCaseData(new YugiohWebPageCard { Description = "This is a big monster", Types = "Insect / Effect" }, typeof(EffectMonster));
        yield return new TestCaseData(new YugiohWebPageCard { Types = "Warrior / Fusion", Materials = "2 Warrior Monsters"}, typeof(FusionMonster));
        yield return new TestCaseData(new YugiohWebPageCard { Description = "This is a big monster", Types = "Warrior / Ritual / Effect"}, typeof(RitualMonster));
        yield return new TestCaseData(new YugiohWebPageCard { Types = "Beast / Synchro", Materials = "2 Beast Monsters"}, typeof(SynchroMonster));
        yield return new TestCaseData(new YugiohWebPageCard { Types = "Aqua / Xyz", Materials = "2 Level 4 Aqua Monsters"}, typeof(XyzMonster));
        yield return new TestCaseData(new YugiohWebPageCard { Description = "Pendulum Effect: You can reduce the battle damage you take from an attack involving a Pendulum Monster you control to 0. During your End Phase: You can destroy this card, and if you do, add 1 Pendulum Monster with 1500 or less ATK from your Deck to your hand. You can only use each Pendulum Effect of \"Odd-Eyes Pendulum Dragon\" once per turn. Monster Effect: If this card battles an opponent's monster, any battle damage this card inflicts to your opponent is doubled.", Types = "Reptile / Pendulum" }, typeof(PendulumMonster));
        yield return new TestCaseData(new YugiohWebPageCard { Types = "Dragon / Normal / Tuner" }, typeof(TunerMonster));
        yield return new TestCaseData(new YugiohWebPageCard { Types = "Dragon / Effect / Gemini", Description = "A Powerful Gemini monster"}, typeof(GeminiMonster));
        yield return new TestCaseData(new YugiohWebPageCard { Types = "Machine / Effect / Union", Description = "A Powerful Union monster" }, typeof(UnionMonster));
        yield return new TestCaseData(new YugiohWebPageCard { Types = "Machine / Effect / Spirit", Description = "A Powerful Spirit monster" }, typeof(SpiritMonster));
        yield return new TestCaseData(new YugiohWebPageCard { Types = "Machine / Effect / Flip", Description = "A Powerful Spirit monster" }, typeof(FlipMonster));
        yield return new TestCaseData(new YugiohWebPageCard { Types = "Machine / Effect / Toon", Description = "A Powerful Toon monster" }, typeof(ToonMonster));
        yield return new TestCaseData(new YugiohWebPageCard { Types = "Machine / Effect / Link", Description = "A Powerful Link monster", LinkArrows = "Top, Bottom-Left, Bottom, Bottom-Right" }, typeof(LinkMonster));
    }
    #endregion


}