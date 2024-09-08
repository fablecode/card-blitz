using CardBlitz.Constants;

namespace CardBlitz.Factories;

public class SpellTypeFactory
{
    public static SpellType CreateSpellType(string cardType)
    {
        return new SpellType(cardType);
    }
}