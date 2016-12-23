using System;
using System.Collections.Generic;
using System.Linq;

public class SumOfMultiples
{
    public static int To(int[] numbers, int to)
    {
        ICollection<int> multiples = new HashSet<int>();
        foreach (var number in numbers)
        {
            int init = 1;
            var multiple = 0;
            while (true) 
            {
                multiple = number * init++;
                if (multiple >= to) 
                {   
                    init = 1;
                    break;
                }
                multiples.Add(multiple);
            }
        }

        return multiples.Sum();
    }

    private static IEnumerable<int> GetMultiples(int number, int to)
    {
        int init = 1;
        int multiple;
        do {
            multiple = number * init++;
            yield return multiple;
        } while (multiple < to);
    }
}