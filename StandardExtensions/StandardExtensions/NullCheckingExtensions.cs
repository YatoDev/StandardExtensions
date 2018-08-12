using System;

namespace NetStandardExtensions
{
    /// <summary>
    ///     Provides extension methods for null checking
    /// </summary>
    public static class NullCheckingExtensions
    {
        /// <summary>
        ///     Determines whether this instance is null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object.</param>
        /// <returns>
        ///     <c>true</c> if the specified object is null; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNull<T>(this T obj) where T : class
        {
            return obj == null;
        }

        /// <summary>
        ///     Determines whether this instance is not null.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object.</param>
        /// <returns>
        ///     <c>true</c> if this instance is not null; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsNotNull<T>(this T obj) where T : class
        {
            return obj != null;
        }

        /// <summary>
        ///     Throws an <c>ArgumentNullException</c> if this instance is null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object.</param>
        /// <param name="paramName">Name of the parameter.</param>
        /// <exception cref="ArgumentNullException">
        /// </exception>
        public static void ThrowIfNull<T>(this T obj, string paramName = null) where T : class
        {
            if (obj != null) return;

            if (string.IsNullOrEmpty(paramName))
                throw new ArgumentNullException();
            throw new ArgumentNullException(paramName);
        }

        /// <summary>
        ///     Returns the default value if the <c>object</c> is null. Otherwise it returns the objects value
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object.</param>
        /// <returns>Returns the default value if the <c>object</c> is null. Otherwise it returns the objects value</returns>
        public static T DefaultIfNull<T>(this T obj) where T : class
        {
            return obj ?? default(T);
        }

        /// <summary>
        ///     Determines whether this instance is initialized to it's default.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">The object.</param>
        /// <returns>
        ///     <c>true</c> if the specified object is initialized to it's default; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsDefault<T>(this T obj) where T : class
        {
            return obj == default(T);
        }
    }
}