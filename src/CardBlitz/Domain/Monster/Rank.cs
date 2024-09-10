using CardBlitz.Core;

namespace CardBlitz.Domain.Monster;

public record Rank(int Value) : IMonsterHierarchy;