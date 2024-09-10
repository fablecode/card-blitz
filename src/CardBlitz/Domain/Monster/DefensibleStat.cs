using CardBlitz.Core;

namespace CardBlitz.Domain.Monster;

public record DefensibleStat(int Atk, int Def) : IMonsterStat;