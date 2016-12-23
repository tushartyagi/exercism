using System;

public class Hamming
{
    public static int Compute(string a, string b) 
    {
        if (a.Length != b.Length) 
            throw new ArgumentException("Strands need to be of the same length"); 

        if (string.Compare(a, b) == 0) return 0;

        int count = 0;
        int differences = 0;

        while (a.Length > count)
        {
            if (a[count] != b[count])
                differences += 1;
            
            count += 1;
        }
        
        return differences;
    }
}