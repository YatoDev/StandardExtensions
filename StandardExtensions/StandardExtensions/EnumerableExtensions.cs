using System;
using System.Collections.Generic;
using System.Text;

namespace StandardExtensions
{
    public static class EnumerableExtensions
    {
        public static IList<T> Clone<T>(this IEnumerable<T> list)
        {
            if (list == null) throw new ArgumentNullException("list");

            IList<T> copy = new List<T>();

            foreach (var item in list)
                copy.Add(item);

            return copy;
        }

        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));
            if (action == null) throw new ArgumentNullException(nameof(action));

            foreach (var item in enumerable)
                action(item);
        }

        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> enumerable, Func<T, T> action)
        {
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));
            if (action == null) throw new ArgumentNullException(nameof(action));

            foreach (var item in enumerable)
                yield return action(item);
        }

        public static IEnumerable<T> Take<T>(this IEnumerable<T> enumerable, Predicate<T> predicate)
        {
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            foreach (var item in enumerable)
            {
                if (predicate(item)) yield return item;
            }
        }

        public static IEnumerable<T> TakeWhile<T>(this IEnumerable<T> enumerable, Predicate<T> predicate)
        {
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            foreach (var item in enumerable)
            {
                if (!predicate(item)) break;

                yield return item;
            }
        }

        public static IEnumerable<T> TakeUntil<T>(this IEnumerable<T> enumerable, Predicate<T> predicate)
        {
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            foreach (var item in enumerable)
            {
                if (predicate(item)) break;

                yield return item;
            }
        }
    }
}
