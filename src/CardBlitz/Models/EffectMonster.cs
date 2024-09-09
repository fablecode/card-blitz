using CardBlitz.Constants;
using CardBlitz.Core;
using System.Text.RegularExpressions;

namespace CardBlitz.Models;

public sealed class EffectMonster(string effect) : IMonsterSubtype
{
    public string Name => MonsterSubtype.Effect;
    public string Effect { get; } = ExtractMonsterEffect(effect);

    public static string ExtractMonsterEffect(string description)
    {
        // Define regex pattern to extract Monster Effect
        const string pattern = "Monster Effect:(.*)";

        // Use regular expression to find the monster effect text
        var match = Regex.Match(description, pattern, RegexOptions.Singleline);

        // Return the captured group (Monster Effect) or entire description if not found
        return match.Success ? match.Groups[1].Value.Trim() : description;
    }

}