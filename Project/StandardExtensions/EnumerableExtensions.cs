using System;
using System.Collections.Generic;
using System.Text;

namespace NetStandardExtensions
{
    /// <summary>
    ///     Provides extension methods for <c>IEnumerable</c>
    /// </summary>
    public static class EnumerableExtensions
    {
        /// <summary>
        ///     Clones the specified enumerable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">The enumerable.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">list</exception>
        public static IList<T> Clone<T>(this IEnumerable<T> list)
        {
            if (list == null) throw new ArgumentNullException(nameof(list));

            IList<T> copy = new List<T>();

            foreach (var item in list)
                copy.Add(item);

            return copy;
        }

        /// <summary>
        ///     Executes an action on every iteration
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="action">The action.</param>
        /// <exception cref="ArgumentNullException">
        ///     enumerable
        ///     or
        ///     action
        /// </exception>
        public static void ForEach<T>(this IEnumerable<T> enumerable, Action<T> action)
        {
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));
            if (action == null) throw new ArgumentNullException(nameof(action));

            foreach (var item in enumerable)
                action(item);
        }

        /// <summary>
        ///     Takes all elements for which the predicate is true
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        ///     enumerable
        ///     or
        ///     predicate
        /// </exception>
        public static IEnumerable<T> Take<T>(this IEnumerable<T> enumerable, Predicate<T> predicate)
        {
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            foreach (var item in enumerable)
                if (predicate(item)) yield return item;
        }

        /// <summary>
        ///     Takes all elements while the predicate returns true
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        ///     enumerable
        ///     or
        ///     predicate
        /// </exception>
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

        /// <summary>
        ///     Takes all elements until the predicate returns true
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">
        ///     enumerable
        ///     or
        ///     predicate
        /// </exception>
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

        /// <summary>
        ///     Flattens the enumeration
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="enumerable">The enumerable.</param>
        /// <param name="seperator">The seperator.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">enumerable</exception>
        /// <exception cref="NullReferenceException">enumerable.Item</exception>
        public static string Flatten<T>(this IEnumerable<T> enumerable, string seperator = "")
        {
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));

            var sb = new StringBuilder();

            foreach (var item in enumerable)
            {
                if (item == null) throw new NullReferenceException("enumerable.Item");

                sb.Append(item + seperator);
            }

            return sb.ToString();
        }
    }
}