using CardBlitz.Core;

namespace CardBlitz.Domain.Monster;

public record LinkStat(int Atk, int LinkRating) : IMonsterStat;