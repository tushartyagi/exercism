using System.Collections.Generic;
using System.Linq;

public class Raindrops
{
    public static string Convert(int number) 
    {
        var factors = Factors(number);
        var raindrop = factors.Aggregate(string.Empty, Accumulate);
        if (string.IsNullOrEmpty(raindrop))
            return number.ToString();
        else
            return raindrop;
    }

    private static string Accumulate(string acc, int number)
    {
        if (number ==  3)
            return acc + "Pling";
        else if (number == 5)
            return acc + "Plang";
        else if (number == 7)
            return acc + "Plong";
        else return acc;
    }

    private static List<int> Factors(int number)
    {
        return Enumerable.Range(1, number).Where(x => number % x == 0).ToList(); 
    }
}