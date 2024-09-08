using CardBlitz.Constants;

namespace CardBlitz.Factories;

public class TrapTypeFactory
{
    public static TrapType CreateTrapType(string cardType)
    {
        return new TrapType(cardType);
    }
}