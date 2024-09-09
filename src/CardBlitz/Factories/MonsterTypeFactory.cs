using CardBlitz.Constants;
using CardBlitz.Models.Monster;

namespace CardBlitz.Factories;

public static class MonsterTypeFactory
{
    public static MonsterType CreateMonsterType(string[] monsterTypes)
    {
        return new MonsterType(monsterTypes.First());
    }
}