using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Domain.Monster;

public sealed class GeminiMonster : IMonsterSubtype
{
    public string Name => MonsterSubtype.Gemini;
}