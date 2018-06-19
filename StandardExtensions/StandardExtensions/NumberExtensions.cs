using System;
using System.Collections.Generic;
using System.Text;

namespace StandardExtensions
{
    public static class NumberExtensions
    {
        public static T Clamp<T>(this T value, T min, T max) where T : IComparable<T>
        {
            int order = value.CompareTo(min);

            if(order < 0)
            {
                return min;
            }
            else if(order > 0)
            {
                return max;
            }
            else
            {
                return value;
            }
        }

        public static T Limit<T>(this T value, T min, T max) where T : IComparable<T>
        {
            return value.Clamp(min, max);
        }
    }
}
