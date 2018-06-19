using System;
using System.Collections.Generic;
using System.Text;

namespace StandardExtensions
{
    public static class StringExtensions
    {
        public static T ConvertTo<T>(this string str)
        {
            return (T)Convert.ChangeType(str, typeof(T));
        }

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

        public static string Format(this string str, params object[] args)
        {
            return string.Format(str, args);
        }

        public static string Concat(this string str, params string[] array)
        {
            return str + string.Concat(array);
        }
    }
}
