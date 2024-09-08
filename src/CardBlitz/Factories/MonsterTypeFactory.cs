using CardBlitz.Constants;

namespace CardBlitz.Factories;

public static class MonsterTypeFactory
{
    public static MonsterType CreateMonsterType(string[] monsterTypes)
    {
        return new MonsterType(monsterTypes.First());
    }
}