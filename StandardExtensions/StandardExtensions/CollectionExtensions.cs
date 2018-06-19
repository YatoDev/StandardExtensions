using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StandardExtensions
{
    public static class CollectionExtensions
    {
        public static bool IsNullOrEmpty(this ICollection collection)
        {
            if (collection == null) return true;
            if (collection.Count == 0) return true;
            return false;
        }

        public static string Flatten<T>(this IEnumerable<T> enumerable, string seperator = "")
        {
            if (enumerable == null) throw new ArgumentNullException(nameof(enumerable));

            StringBuilder sb = new StringBuilder();

            foreach(var item in enumerable)
            {
                if (item == null) throw new NullReferenceException("enumerable.Item");

                sb.Append(item.ToString() + seperator);
            }

            return sb.ToString();
        }
    }
}
