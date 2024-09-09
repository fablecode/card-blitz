using CardBlitz.Constants;
using CardBlitz.Domain.Monster;

namespace CardBlitz.Factories;

public static class MonsterAttributeFactory
{
    public static MonsterAttribute CreateMonsterAttribute(string attribute)
    {
        return new MonsterAttribute(attribute);
    }
}