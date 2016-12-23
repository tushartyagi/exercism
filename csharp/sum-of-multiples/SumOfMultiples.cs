using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfMultiples
{
    public static int To(int[] numbers, int upto)
    {
        HashSet<int> multiples = new HashSet<int>();
        foreach (var number in numbers)
        {
            foreach (var multiple in GetMultiples(number, upto))
            {
                multiples.Add(multiple);
            }
        }

        return multiples.Sum();
    }

    private static IEnumerable<int> GetMultiples(int number, int upto)
    {
        int init = 1;
        int multiple;
        while (true)
        {
            multiple = number * init++;
            if (multiple >= upto) break;
            yield return multiple;
        }
    }
}