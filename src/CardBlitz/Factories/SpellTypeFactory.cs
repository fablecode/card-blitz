using CardBlitz.Constants;
using CardBlitz.Domain.Spell;

namespace CardBlitz.Factories;

public class SpellTypeFactory
{
    public static SpellType CreateSpellType(string cardType)
    {
        return new SpellType(cardType);
    }
}