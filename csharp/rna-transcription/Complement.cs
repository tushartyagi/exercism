using System;
using System.Linq;
public class Complement 
{
    public static string OfDna(string strand)
    {
        return new String(strand.Select(DNA2RNA).ToArray());
    }

    private static char DNA2RNA(char c) 
    {
        switch (c) 
        {
            case 'G':
            return 'C';
            
            case 'C':
            return 'G';

            case 'T':
            return 'A';

            case 'A':
            return 'U';

            default:
            throw new ArgumentException("Look look! A new dna");
        }
    }
}