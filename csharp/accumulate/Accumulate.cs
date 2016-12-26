using System;
using System.Collections.Generic;
using System.Linq;

public static class AccumulatorImpl
{

    public static IEnumerable<T> Accumulate<T>(this IEnumerable<T> xs, Func<T, T> f)
    {
        return AccumulateViaYield(xs, f);
    }

    private static IEnumerable<T> AccumulateViaYield<T>(this IEnumerable<T> xs, Func<T, T> f)
    {
        foreach (var x in xs) {
            yield return f(x);
        } 
    }

    private static IEnumerable<T> AccumulateViaBuiltIn<T>(this IEnumerable<T> xs, Func<T, T> f) {
        return xs.Select(f);
    }

    private static IEnumerable<T> AccumulateViaConsing<T>(this IEnumerable<T> xs, Func<T, T> f)
    {
        return xs.AccumulateViaConsing_Helper(f);
    }


    private static IEnumerable<T> AccumulateViaConsing_Helper<T>(this IEnumerable<T> xs, Func<T, T> f)
    {
        // This enumerates the entire collection, so lazyness is killed
        // if (xs.Count() == 0) return xs;

        T head; 
        IEnumerable<T> tail;

        try {
            head = xs.First();
            
        }
        catch (InvalidOperationException) {
            return xs;
        }

        tail = xs.Skip(1);

        var mappedHead = f(head);
        var mappedTail = tail.AccumulateViaConsing_Helper(f);

        return mappedTail.Prepend(mappedHead);
    }

    
}