namespace Exercism_strain
{
    using System;
    using System.Collections.Generic;

    public static class Extenstions
    {
        public static IEnumerable<T> Keep<T>(this IEnumerable<T> source, Func<T, bool> pred)
        {
            foreach (var element in source)
            {
                if (pred(element))
                {
                    yield return element;
                }
            }
        }

        public static IEnumerable<T> Discard<T>(this IEnumerable<T> source, Func<T, bool> pred)
        {
            foreach (var element in source)
            {
                if (!pred(element))
                {
                    yield return element;
                }
            }
        }
    }
}
