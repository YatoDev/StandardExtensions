using System;
using System.Collections.Generic;
using System.Text;

namespace StandardExtensions
{
    public static class ConvertingExtensions
    {
        public static TTo Convert<TFrom, TTo>(this TFrom from)
        {
            return (TTo)System.Convert.ChangeType(from, typeof(TTo));
        }

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
