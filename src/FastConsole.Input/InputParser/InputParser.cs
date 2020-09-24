using System;
using System.Globalization;

namespace FastConsole
{
    /// <summary>
    /// Static methods to parse strings to number types.
    /// </summary>
    public static class InputParser
    {
        #region Props
        /// <summary>
        /// The NumberStyles used by the conversions in this class.
        /// </summary>
        /// <value></value>
        public static NumberStyles NumberStyles { get; set; } = NumberStyles.Number;

        /// <summary>
        /// The IFormatProvider used by the conversions in this class.<para/>
        /// By default it calls 'CultureInfo.CurrentCulture', so you could just change 'CultureInfo.CurrentCulture'.
        /// But you can also change only the 'InputParser.FormatProvider' value!
        /// </summary>
        /// <value></value>
        public static IFormatProvider FormatProvider { get => _culture ?? CultureInfo.CurrentCulture; set => _culture = value; }
        private static IFormatProvider _culture = null;
        #endregion
        
        /// <summary>
        /// Tries to parse the string to sbyte. <para/>
        /// If it fails, null is returned.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static sbyte? ParseSbyte(string s)
        {
            try
            {
                return sbyte.Parse(s, NumberStyles, FormatProvider);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Tries to parse the string to byte. <para/>
        /// If it fails, null is returned.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte? ParseByte(string s)
        {
            try
            {
                return byte.Parse(s, NumberStyles, FormatProvider);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Tries to parse the string to ushort. <para/>
        /// If it fails, null is returned.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static ushort? ToUshort(string s)
        {
            try
            {
                return ushort.Parse(s, NumberStyles, FormatProvider);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Tries to parse the string to short. <para/>
        /// If it fails, null is returned.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static short? ToShort(string s)
        {
            try
            {
                return short.Parse(s, NumberStyles, FormatProvider);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Tries to parse the string to uint. <para/>
        /// If it fails, null is returned.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static uint? ToUint(string s)
        {
            try
            {
                return uint.Parse(s, NumberStyles, FormatProvider);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Tries to parse the string to int. <para/>
        /// If it fails, null is returned.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int? ToInt(string s)
        {
            try
            {
                return int.Parse(s, NumberStyles, FormatProvider);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Tries to parse the string to ulong. <para/>
        /// If it fails, null is returned.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static ulong? ToUlong(string s)
        {
            try
            {
                return ulong.Parse(s, NumberStyles, FormatProvider);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Tries to parse the string to long. <para/>
        /// If it fails, null is returned.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static long? ToLong(string s)
        {
            try
            {
                return long.Parse(s, NumberStyles, FormatProvider);
            }
            catch (Exception)
            {
                return null;
            }
        }
        
        /// <summary>
        /// Tries to parse the string to decimal. <para/>
        /// If it fails, null is returned.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static decimal? ToDecimal(string s)
        {
            try
            {
                return decimal.Parse(s, NumberStyles, FormatProvider);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Tries to parse the string to float. <para/>
        /// If it fails, null is returned.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static float? ToFloat(string s)
        {
            try
            {
                return float.Parse(s, NumberStyles, FormatProvider);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Tries to parse the string to double. <para/>
        /// If it fails, null is returned.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static double? ToDouble(string s)
        {
            try
            {
                return double.Parse(s, NumberStyles, FormatProvider);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}