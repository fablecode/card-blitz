using CardBlitz.Core;

namespace CardBlitz.Domain.Monster;

public record Level(int Value) : IMonsterHierarchy;