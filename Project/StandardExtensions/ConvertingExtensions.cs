namespace NetStandardExtensions
{
    /// <summary>
    ///     Provides extension methods to convert types
    /// </summary>
    public static class ConvertingExtensions
    {
        /// <summary>
        ///     Converts any type to a target type
        /// </summary>
        /// <typeparam name="TFrom">The type to convert from.</typeparam>
        /// <typeparam name="TTo">The type to convert to</typeparam>
        /// <param name="from">The instance.</param>
        /// <returns></returns>
        public static TTo Convert<TFrom, TTo>(this TFrom from)
        {
            return (TTo) System.Convert.ChangeType(from, typeof(TTo));
        }

        /// <summary>
        ///     Tries to convert a type into another
        /// </summary>
        /// <typeparam name="TFrom">The type to convert from.</typeparam>
        /// <typeparam name="TTo">The type of to.</typeparam>
        /// <param name="from">The instance.</param>
        /// <param name="result">The result.</param>
        /// <returns></returns>
        public static bool TryConvert<TFrom, TTo>(this TFrom from, out TTo result)
        {
            try
            {
                result = from.Convert<TFrom, TTo>();
                return true;
            }
            catch
            {
                result = default(TTo);
                return false;
            }
        }
    }
}