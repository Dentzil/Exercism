namespace Exercism_accumulate
{
    using System;
    using System.Collections.Generic;

    public static class CustomExtensions
    {
        public static IEnumerable<TResult> Accumulate<TSource, TResult>(this IEnumerable<TSource> source, Func<TSource, TResult> func)
        {
            foreach (var element in source)
            {
                yield return func(element);
            }
        }
    }
}
