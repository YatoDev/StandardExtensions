using System;
using System.Collections.Generic;
using System.Text;

namespace StandardExtensions
{
    /// <summary>
    /// Provides extension methods for number types
    /// </summary>
    public static class NumberExtensions
    {
        /// <summary>
        /// Clamps a number to a specific minimum and maximum value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="min">The minimum.</param>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Limits a number to not exceed a specific maximum
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value">The value.</param>
        /// <param name="max">The maximum.</param>
        /// <returns></returns>
        public static T Limit<T>(this T value, T max) where T : IComparable<T>
        {
            if (value.CompareTo(max) > 0) return max;

            return value;
        }
    }
}
