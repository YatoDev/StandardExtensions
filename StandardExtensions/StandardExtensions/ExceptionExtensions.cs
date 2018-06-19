using System;
using System.Collections.Generic;
using System.Text;

namespace NetStandardExtensions
{
    /// <summary>
    /// Provides extension methods to throw exceptions
    /// </summary>
    public static class ExceptionExtensions
    {
        /// <summary>
        /// Throws an exception whith the text contained in this instance
        /// </summary>
        /// <param name="str">The string.</param>
        /// <exception cref="Exception">
        /// </exception>
        public static void Throw(this string str)
        {
            if(string.IsNullOrEmpty(str))
            {
                throw new Exception();
            }
            else
            {
                throw new Exception(str);
            }
        }

        /// <summary>
        /// Throws an exception with type information and an optional exception text
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="text">The text.</param>
        /// <exception cref="Exception">
        /// </exception>
        public static void Throw<T>(this T obj, string text = "") where T : class
        {
            if(obj == null)
            {
                if (!string.IsNullOrEmpty(text)) throw new Exception(text);

                throw new Exception();
            }
            else
            {
                if (!string.IsNullOrEmpty(text)) throw new Exception(obj.ToString() + text);

                throw new Exception(obj.ToString());
            }
        }

        /// <summary>
        /// Throws an exception if the predicate returns true
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="predicate">The predicate.</param>
        /// <param name="text">The text.</param>
        /// <exception cref="ArgumentNullException">predicate</exception>
        public static void ThrowIf<T>(this T obj, Predicate<T> predicate, string text = "") where T : class
        {
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            if(predicate(obj))
            {
                obj.Throw(text);
            }
        }

        /// <summary>
        /// Exceutes an action and does not throw on exceptions
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="action">The action.</param>
        public static void DoNotThrow<T>(this T obj, Action<T> action) where T : class
        {
            if (action == null) return;

            try
            {
                action(obj);
            }
            catch
            {

            }
        }
    }
}
