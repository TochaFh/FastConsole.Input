using System;

namespace FastConsole
{
    /// <summary>
    /// The main static class of FastConsole (.Input) for getting input from the console.
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
        /// Invokes the opt 'RequestMessage()' and reads the next line from the console.<para/>
        /// If it is null or empty or white space, a decision is made according to opt.
        /// </summary>
        /// <param name="opt"></param>
        /// <returns></returns>
        public static string ReadString(IInputOptions opt)
        {
            opt.RequestMessage();

            string s = In.ReadLine();

            if (!string.IsNullOrWhiteSpace(s)) return s;

            if (opt.ShowInvalidMessage) opt.InvalidInputMessage();

            if (opt.RepeatWhenInvalid) return In.ReadString(opt);

            return null;
        }

        /// <summary>
        /// Invokes the opt 'RequestMessage()' and reads the next line from the console.<para/>
        /// Uses the Func to parse the string and, if it returns null, a decision is made according to opt.
        /// </summary>
        /// <param name="opt"></param>
        /// <param name="parse"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ReadInput<T>(IInputOptions opt, Func<string, T> parse)
        {
            opt.RequestMessage();

            T result = parse(In.ReadLine());

            if (result != null) return result;

            if (opt.ShowInvalidMessage) opt.InvalidInputMessage();

            if (opt.RepeatWhenInvalid) return In.ReadInput<T>(opt, parse);

            return default(T);
        }

        /// <summary>
        /// Returns 'ReadInput(IInputOptions opt, Func parse)' with the specified parse parameter and an IInputOptions based on the specified string.
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <param name="parse"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static T ReadInput<T>(string requestMessage, Func<string, T> parse)
        {
            return ReadInput<T>(requestMessage.InputOpt(), parse);
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
    }
}