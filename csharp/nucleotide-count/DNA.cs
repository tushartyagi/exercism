using System.Collections.Generic;
using System.Linq;

public class DNA
{
    private string _dnaString;
    public Dictionary<char, int> NucleotideCounts { get; private set; } = new Dictionary<char, int> { 
        { 'A', 0 }, 
        { 'T', 0 }, 
        { 'C', 0 }, 
        { 'G', 0 } 
    };

    public DNA(string dnaString)
    {
        _dnaString = dnaString;
        UpdateCounts(_dnaString);
    }

    private void UpdateCounts(string dnaString)
    {
        dnaString.ToList().ForEach(c => {
            NucleotideCounts[c] += 1;
        });
    }

    public int Count(char nucleotide) 
    {
        int count;

        if (!NucleotideCounts.ContainsKey(nucleotide))
        {
            throw new InvalidNucleotideException();
        }

        if (NucleotideCounts.TryGetValue(nucleotide, out count))
        {
            return count;
        }
        else return 0;
    }



}

public class InvalidNucleotideException : System.Exception {}