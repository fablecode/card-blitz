using System.Text.RegularExpressions;
using CardBlitz.Constants;
using CardBlitz.Core;

namespace CardBlitz.Models.Monster;

public sealed class PendulumMonster(int scale, string effect) : IMonsterSubtype
{
    public string Name => MonsterSubtype.Pendulum;
    public int Scale { get; } = scale;
    public string Effect { get; } = ExtractPendulumEffect(effect);

    public static string ExtractPendulumEffect(string description)
    {
        // Define regex pattern to extract Pendulum Effect
        const string pattern = "Pendulum Effect:(.*?)(?=Monster Effect|$)";

        // Use regular expression to find the pendulum effect text
        var match = Regex.Match(description, pattern, RegexOptions.Singleline);

        // Return the captured group (Pendulum Effect)
        return match.Success ? match.Groups[1].Value.Trim() : string.Empty;
    }

}