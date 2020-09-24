namespace FastConsole
{
    // Helpers to create IInputOptions
    public static partial class In
    {

        /// <summary>
        /// Creates a SimpleInputOpt with this string as the request message and the specified bool parameters.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="repeatWhenInvalid"></param>
        /// <param name="showInvalidMessage"></param>
        /// <returns></returns>
        public static SimpleInputOpt InputOpt(this string s, bool repeatWhenInvalid = true, bool showInvalidMessage = true)
        {
            return new SimpleInputOpt(s) { RepeatWhenInvalid = repeatWhenInvalid, ShowInvalidMessage = showInvalidMessage };
        }

        /// <summary>
        /// Creates a SimpleInputOpt with the specified messages and the specified bool parameters.
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <param name="invalidInputMessage"></param>
        /// <param name="repeatWhenInvalid"></param>
        /// <param name="showInvalidMessage"></param>
        /// <returns></returns>
        public static SimpleInputOpt InputOpt(string requestMessage, string invalidInputMessage, bool repeatWhenInvalid = true, bool showInvalidMessage = true)
        {
            return new SimpleInputOpt(requestMessage, invalidInputMessage) { RepeatWhenInvalid = repeatWhenInvalid, ShowInvalidMessage = showInvalidMessage };
        }


        /// <summary>
        /// Creates a CoolInputOpt with this CoolText as the request message and the specified bool parameters.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="repeatWhenInvalid"></param>
        /// <param name="showInvalidMessage"></param>
        /// <returns></returns>
        public static CoolInputOpt InputOpt(this CoolText text, bool repeatWhenInvalid = true, bool showInvalidMessage = true)
        {
            return new CoolInputOpt(text) { RepeatWhenInvalid = repeatWhenInvalid, ShowInvalidMessage = showInvalidMessage };
        }

        /// <summary>
        /// Creates a CoolInputOpt with the specified (CoolText) messages and the specified bool parameters.
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <param name="invalidInputMessage"></param>
        /// <param name="repeatWhenInvalid"></param>
        /// <param name="showInvalidMessage"></param>
        /// <returns></returns>
        public static CoolInputOpt InputOpt(CoolText requestMessage, CoolText invalidInputMessage, bool repeatWhenInvalid = true, bool showInvalidMessage = true)
        {
            return new CoolInputOpt(requestMessage, invalidInputMessage) { RepeatWhenInvalid = repeatWhenInvalid, ShowInvalidMessage = showInvalidMessage };
        }


        /// <summary>
        /// Creates a CoolInputOpt with this CoolSnippet as the request message and the specified bool parameters.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="repeatWhenInvalid"></param>
        /// <param name="showInvalidMessage"></param>
        /// <returns></returns>
        public static CoolInputOpt InputOpt(this CoolSnippet text, bool repeatWhenInvalid = true, bool showInvalidMessage = true)
        {
            return new CoolInputOpt((CoolText)text) { RepeatWhenInvalid = repeatWhenInvalid, ShowInvalidMessage = showInvalidMessage };
        }

        /// <summary>
        /// Creates a CoolInputOpt with the specified (CoolSnippet) messages and the specified bool parameters.
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <param name="invalidInputMessage"></param>
        /// <param name="repeatWhenInvalid"></param>
        /// <param name="showInvalidMessage"></param>
        /// <returns></returns>
        public static CoolInputOpt InputOpt(CoolSnippet requestMessage, CoolSnippet invalidInputMessage, bool repeatWhenInvalid = true, bool showInvalidMessage = true)
        {
            return new CoolInputOpt((CoolText)requestMessage, (CoolText)invalidInputMessage) { RepeatWhenInvalid = repeatWhenInvalid, ShowInvalidMessage = showInvalidMessage };
        }
    }
}