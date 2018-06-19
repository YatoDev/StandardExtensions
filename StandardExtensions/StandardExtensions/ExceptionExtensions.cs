using System;
using System.Collections.Generic;
using System.Text;

namespace StandardExtensions
{
    public static class ExceptionExtensions
    {
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

        public static void ThrowIf<T>(this T obj, Predicate<T> predicate, string text = "") where T : class
        {
            if (predicate == null) throw new ArgumentNullException(nameof(predicate));

            if(predicate(obj))
            {
                obj.Throw(text);
            }
        }

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
