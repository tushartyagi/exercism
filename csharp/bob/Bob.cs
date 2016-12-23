using System.Linq;
public class Bob
{
    public static string Hey(string iSay)
    {
        var whatHeSays = iSay.Trim();

        if (IsAYell(whatHeSays))
        {
            return "Whoa, chill out!";
        }
        else if (IsAQuestion(whatHeSays)) 
        {
            return "Sure.";
        }
        else if (IsSilence(whatHeSays))
        {
            return "Fine. Be that way!";
        }
        
        return "Whatever.";
    }

    private static bool IsAQuestion(string whatHeSays)
    {
        return whatHeSays.EndsWith("?");
    }

    private static bool IsSilence(string whatHeSays)
    {
        return whatHeSays == string.Empty;
    }

    private static bool IsAYell(string saying)
    {
        // If all the alphabets are in uppercase, it is a yell. 
        // This removes the mix of numbers, special chars, etc.
        // No unicode.

        return saying.Any(char.IsLetter) && 
            saying.Where(char.IsLetter).All(char.IsUpper);
    }
}