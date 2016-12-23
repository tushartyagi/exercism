using System.Collections.Generic;
using System.Linq;

public class Pangram
{
    private static char[] _alphabets = "abcdefghijklmnopqrstuvwxyz".ToCharArray(); 

    public static bool IsPangram(string input) {
        return Panagram2(input);
    }

    public static bool Panagram1(string input)
    {
        var set = new HashSet<char>();
        foreach (char c in input) 
        {
            var lower = char.ToLower(c);
            if (_alphabets.Contains(lower))
            {
                set.Add(lower);
            }
        }
        if (set.Count == 26) return true;
        else return false;
    }

    public static bool Panagram2(string input) 
    {
        var lowercase = input.ToLower();
        return _alphabets.All(lowercase.Contains);
    }
}