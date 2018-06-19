using System;
using System.Collections.Generic;
using System.Text;

namespace StandardExtensions
{
    public static class StringExtensions
    {
        /// <summary>
        /// Converts a string to another type using it's default conversion method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public static T ConvertTo<T>(this string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }

        /// <summary>
        /// Tries to convert a string to another type using it's default conversion method
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="str">The string.</param>
        /// <param name="result">The result.</param>
        /// <returns></returns>
        public static bool TryConvertTo<T>(this string str, out T result)
        {
            try
            {
                result = str.ConvertTo<T>();
                return true;
            }
            catch
            {
                result = default(T);
                return false;
            }
        }

        /// <summary>
        /// A shortcut for <c>string.Format</c>
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="args">The arguments.</param>
        /// <returns></returns>
        public static string Format(this string str, params object[] args)
        {
            return string.Format(str, args);
        }

        /// <summary>
        /// A shortcut for <c>string.Concat</c>
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="array">The array.</param>
        /// <returns></returns>
        public static string Concat(this string str, params string[] array)
        {
            return str + string.Concat(array);
        }
    }
}
