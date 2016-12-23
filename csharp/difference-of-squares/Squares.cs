using System;
using System.Linq;
public class Squares
{
    private int _range;
    public Squares(int n)
    {
        if (n < 0) throw new ArgumentException("Numbers cannot be negative");
        _range = n;
    }

    public int SquareOfSums() 
    {
        var sum = Enumerable.Range(1, _range).Sum();
        return sum * sum; 
    }

    public int DifferenceOfSquares() 
    {
        return SquareOfSums() - SumOfSquares();
    }

    public int SumOfSquares() 
    {
        return Enumerable.Range(1, _range).Select(x => x * x).Sum();
    }
}