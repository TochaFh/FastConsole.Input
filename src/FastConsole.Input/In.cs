using System;

namespace FastConsole
{
    /// <summary>
    /// The main static class of FastConsole (.Input) for getting input from the console.
    /// Easy input with messages, validationd, etc.
    /// </summary>
    public static partial class In
    {
        /// <summary>
        /// If you just want to 'ReadLine()' with no validation.<para/> 
        /// Reads the next line of characters from the console.<para/>
        /// Equivalent to 'Console.ReadLine()'.
        /// </summary>
        /// <returns></returns>
        public static string ReadLine()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// If you just want to 'ReadLine()' with no validation.<para/>
        /// Prints the a request message and reads the next line of characters from the console.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public static string ReadLine(string request)
        {
            Out.Print(request);
            return In.ReadLine();
        }

        /// <summary>
        /// Returns 'ReadInput(IInputOptions opt, Func parse)'* with the specified parameters.
        /// If you don't specify the 'parse' parameter, it will automatically check for empty string<para/>
        /// * Invokes the opt 'RequestMessage()' and reads the next line from the console.
        /// Uses the Func to parse and validate the input and, if it returns null, a decision is made according to opt.<para/>
        /// - If you just want the raw string, use <c>In.ReadLine</c>
        /// </summary>
        /// <param name="opt"></param>
        /// <param name="parse">
        /// If null (default value), will be: '<c>(s) => string.IsNullOrWhiteSpace(s) ? null : s</c>'<para/>
        /// </param>
        /// <returns></returns>
        public static string ReadString(IInputOptions opt, Func<string, string> parse = null)
        {
            if (parse == null) parse = s => string.IsNullOrWhiteSpace(s) ? null : s;
            return In.ReadInput<string>(opt, parse);
        }

        /// <summary>
        /// Returns 'ReadInput(string requestMessage, Func parse)'* with the specified parameters.
        /// If you don't specify the 'parse' parameter, it will automatically check for empty string<para/>
        /// * Returns 'ReadInput(IInputOptions opt, Func parse)'* with the specified parse parameter and a SimpleInputOpt based on the specified string.<para/>
        /// - If you just want the raw string, use <c>In.ReadLine</c>
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <param name="parse">
        /// If null (default value), will be: '<c>(s) => string.IsNullOrWhiteSpace(s) ? null : s</c>'<para/>
        /// </param>
        /// <returns></returns>
        public static string ReadString(string requestMessage, Func<string, string> parse = null)
        {
            if (parse == null) parse = s => string.IsNullOrWhiteSpace(s) ? null : s;
            return In.ReadInput<string>(requestMessage, parse);
        }

        /// <summary>
        /// Invokes the opt 'RequestMessage()' and reads the next line from the console.
        /// Uses the Func to parse and validate the input and, if it returns null, a decision is made according to opt.
        /// </summary>
        /// <param name="opt"></param>
        /// <param name="parse"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ReadInput<T>(IInputOptions opt, Func<string, T> parse)
        {
            opt.PrintRequestMsg();

            if (parse == null) throw new ArgumentNullException("parse");

            T result = parse(In.ReadLine());

            if (result != null) return result;

            if (opt.ShowInvalidInputMsg) opt.PrintInvalidInputMsg();

            if (opt.RepeatWhenInvalid) return In.ReadInput<T>(opt, parse);

            return default(T);
        }

        /// <summary>
        /// Returns 'ReadInput(IInputOptions opt, Func parse)'* with the specified parse parameter and a SimpleInputOpt based on the specified string.
        /// <para/>
        /// * Invokes the opt 'RequestMessage()' and reads the next line from the console.
        /// Uses the Func to parse and validate the input and, if it returns null, a decision is made according to opt.
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <param name="parse"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ReadInput<T>(string requestMessage, Func<string, T> parse)
        {
            return ReadInput<T>(requestMessage.InOpt(), parse);
        }

        #region Shortcuts
        /// <summary>
        /// Invokes 'ReadInput' with the specified options and a parser to ushort.
        /// </summary>
        /// <param name="opt"></param>
        /// <returns></returns>
        public static ushort? ReadUshort(IInputOptions opt)
        {
            return ReadInput<ushort?>(opt, InputParser.ToUshort);
        }

        /// <summary>
        /// Invokes 'ReadInput' with the specified options and a parser to short.
        /// </summary>
        /// <param name="opt"></param>
        /// <returns></returns>
        public static short? ReadShort(IInputOptions opt)
        {
            return ReadInput<short?>(opt, InputParser.ToShort);
        }

        /// <summary>
        /// Invokes 'ReadInput' with the specified options and a parser to uint.
        /// </summary>
        /// <param name="opt"></param>
        /// <returns></returns>
        public static uint? ReadUint(IInputOptions opt)
        {
            return ReadInput<uint?>(opt, InputParser.ToUint);
        }

        /// <summary>
        /// Invokes 'ReadInput' with the specified options and a parser to int.
        /// </summary>
        /// <param name="opt"></param>
        /// <returns></returns>
        public static int? ReadInt(IInputOptions opt)
        {
            return ReadInput<int?>(opt, InputParser.ToInt);
        }

        /// <summary>
        /// Invokes 'ReadInput' with the specified options and a parser to ulong.
        /// </summary>
        /// <param name="opt"></param>
        /// <returns></returns>
        public static ulong? ReadUlong(IInputOptions opt)
        {
            return ReadInput<ulong?>(opt, InputParser.ToUlong);
        }

        /// <summary>
        /// Invokes 'ReadInput' with the specified options and a parser to long.
        /// </summary>
        /// <param name="opt"></param>
        /// <returns></returns>
        public static long? ReadLong(IInputOptions opt)
        {
            return ReadInput<long?>(opt, InputParser.ToLong);
        }

        /// <summary>
        /// Invokes 'ReadInput' with the specified options and a parser to float.
        /// </summary>
        /// <param name="opt"></param>
        /// <returns></returns>
        public static float? ReadFloat(IInputOptions opt)
        {
            return ReadInput<float?>(opt, InputParser.ToFloat);
        }

        /// <summary>
        /// Invokes 'ReadInput' with the specified options and a parser to double.
        /// </summary>
        /// <param name="opt"></param>
        /// <returns></returns>
        public static double? ReadDouble(IInputOptions opt)
        {
            return ReadInput<double?>(opt, InputParser.ToDouble);
        }

        /// <summary>
        /// Invokes 'ReadInput' with the specified options and a parser to byte.
        /// </summary>
        /// <param name="opt"></param>
        /// <returns></returns>
        public static byte? ReadByte(IInputOptions opt)
        {
            return ReadInput<byte?>(opt, InputParser.ParseByte);
        }

        /// <summary>
        /// Invokes 'ReadInput' with the specified options and a parser to sbyte.
        /// </summary>
        /// <param name="opt"></param>
        /// <returns></returns>
        public static sbyte? ReadSbyte(IInputOptions opt)
        {
            return ReadInput<sbyte?>(opt, InputParser.ParseSbyte);
        }
        #endregion
    }
}