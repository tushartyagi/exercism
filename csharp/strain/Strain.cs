using System;
using System.Collections.Generic;

namespace StrainExtensions
{
    public static class StrainExtensions
    {
        public static IEnumerable<T> Keep<T>(this IEnumerable<T> xs, Func<T, bool> p)
        {
            foreach (var x in xs)
            {
                if (p(x)) yield return x;
            }
        }

        public static IEnumerable<T> Discard<T>(this IEnumerable<T> xs, Func<T, bool> p)
        {
            foreach (var x in xs)
            {
                if (!p(x)) yield return x;
            }
        }
    }
}