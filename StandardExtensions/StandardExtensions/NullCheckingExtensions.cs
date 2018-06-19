using System;
using System.Collections.Generic;
using System.Text;

namespace StandardExtensions
{
    public static class NullCheckingExtensions
    {
        public static bool IsNull<T>(this T obj) where T : class
        {
            return obj == null;
        }

        public static bool IsNotNull<T>(this T obj) where T : class
        {
            return obj != null;
        }

        public static void ThrowIfNull<T>(this T obj, string paramName = null) where T : class
        {
            if (obj != null) return;

            if(string.IsNullOrEmpty(paramName))
            {
                throw new ArgumentNullException();
            }
            else
            {
                throw new ArgumentNullException(paramName);
            }
        }

        public static T DefaultIfNull<T>(this T obj) where T : class
        {
            if (obj == null) return default(T);

            return obj;
        }
    }
}
