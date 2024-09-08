using CardBlitz.Constants;

namespace CardBlitz.Models;

public interface ICard
{
    long Id { get; }
    ICardType CardType { get; }
}

public sealed class Card(long id, ICardType cardType) : ICard
{
    public long Id { get; } = id;
    public ICardType CardType { get; } = cardType;
}

public interface ICardType
{
    string Name { get; }
}

#region Card types
public sealed class MonsterCard : ICardType
{
    public MonsterCard(string name, MonsterAttribute attribute, MonsterType type, IEnumerable<IMonsterSubtype> subTypes)
    {
        Name = name; 
        Attribute = attribute;
        Type = type;
        SubTypes = subTypes;
    }

    public string Name { get; }
    public MonsterAttribute Attribute { get; }
    public MonsterType Type { get; }
    public IEnumerable<IMonsterSubtype> SubTypes { get; }
}

public sealed class SpellCard : ICardType
{
    public string Name => "Spell";
}
public sealed class TrapCard : ICardType
{
    public string Name => "Trap";
}
#endregion

//#region Monster attributes
//public interface IMonsterAttribute
//{
//    string Name { get; }
//}

//public sealed class DarkAttribute : IMonsterAttribute
//{
//    public string Name => MonsterAttribute.Dark;
//}
//public sealed class LightAttribute : IMonsterAttribute
//{
//    public string Name => MonsterAttribute.Light;
//}
//public sealed class EarthAttribute : IMonsterAttribute
//{
//    public string Name => MonsterAttribute.Earth;
//}
//public sealed class FireAttribute : IMonsterAttribute
//{
//    public string Name => MonsterAttribute.Fire;
//}
//public sealed class WaterAttribute : IMonsterAttribute
//{
//    public string Name => MonsterAttribute.Water;
//}
//public sealed class WindAttribute : IMonsterAttribute
//{
//    public string Name => MonsterAttribute.Wind;
//}
//public sealed class DivineAttribute : IMonsterAttribute
//{
//    public string Name => MonsterAttribute.Divine;
//}
//#endregion


//#region Monster types

//public interface IMonsterType
//{
//    string Name { get; }
//}

//public class DragonMonster : IMonsterType
//{
//    public string Name => MonsterType.Dragon;
//}

//#endregion

#region Monster sub types

public interface IMonsterSubtype
{
    string Name { get; }
}

public sealed class NormalMonster : IMonsterSubtype
{
    public NormalMonster(string description)
    {
        Description = description;
    }

    public string Name => MonsterSubtype.Normal;
    public string Description { get; }
}
public sealed class EffectMonster : IMonsterSubtype
{
    public EffectMonster(string effect)
    {
        Effect = effect;
    }

    public string Name => MonsterSubtype.Effect;
    public string Effect { get; }
}

public sealed class FusionMonster : IMonsterSubtype
{
    public FusionMonster(string materials)
    {
        Materials = materials;
    }

    public string Name => MonsterSubtype.Fusion;
    public string Materials { get; }
}

public sealed class RitualMonster : IMonsterSubtype
{
    public string Name => MonsterSubtype.Ritual;
    public int RitualSpellCard { get; set; }
}

public sealed class SynchroMonster : IMonsterSubtype
{
    public SynchroMonster(string materials)
    {
        Materials = materials;
    }

    public string Name => MonsterSubtype.Synchro;
    public string Materials { get; }
}

public sealed class XyzMonster : IMonsterSubtype
{
    public XyzMonster(string materials)
    {
        Materials = materials;
    }

    public string Name => MonsterSubtype.Xyz;
    public string Materials { get; }
}

public sealed class PendulumMonster : IMonsterSubtype
{
    public PendulumMonster(int scale, string effect)
    {
        Scale = scale;
        Effect = effect;
    }

    public string Name => MonsterSubtype.Pendulum;
    public int Scale { get; }
    public string Effect { get; }
}

#endregion