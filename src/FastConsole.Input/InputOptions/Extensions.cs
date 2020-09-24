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
        public static SimpleInputOpt InOpt(this string s, bool repeatWhenInvalid = true, bool showInvalidMessage = true)
        {
            return new SimpleInputOpt(s) { RepeatWhenInvalid = repeatWhenInvalid, ShowInvalidInputMsg = showInvalidMessage };
        }

        /// <summary>
        /// Creates a SimpleInputOpt with the specified messages and the specified bool parameters.
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <param name="invalidInputMessage"></param>
        /// <param name="repeatWhenInvalid"></param>
        /// <param name="showInvalidMessage"></param>
        /// <returns></returns>
        public static SimpleInputOpt InOpt(string requestMessage, string invalidInputMessage, bool repeatWhenInvalid = true, bool showInvalidMessage = true)
        {
            return new SimpleInputOpt(requestMessage, invalidInputMessage) { RepeatWhenInvalid = repeatWhenInvalid, ShowInvalidInputMsg = showInvalidMessage };
        }

        /// <summary>
        /// Creates a SimpleInputOpt with the specified messages in the tuple and the specified bool parameters.
        /// </summary>
        /// <param name="msgs">1 - requestMessage<para/>2 - invalidInputMessage</param>
        /// <param name="repeatWhenInvalid">repeatWhenInvalid</param>
        /// <param name="showInvalidMessage">showInvalidMessage</param>
        /// <returns></returns>
        public static SimpleInputOpt InOpt(this (string requestMessage, string invalidInputMessage) msgs, bool repeatWhenInvalid = true, bool showInvalidMessage = true)
        {
            return new SimpleInputOpt(msgs.requestMessage, msgs.invalidInputMessage) { RepeatWhenInvalid = repeatWhenInvalid, ShowInvalidInputMsg = showInvalidMessage };
        }


        /// <summary>
        /// Creates a CoolInputOpt with this CoolText as the request message and the specified bool parameters.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="repeatWhenInvalid"></param>
        /// <param name="showInvalidMessage"></param>
        /// <returns></returns>
        public static CoolInputOpt InOpt(this CoolText text, bool repeatWhenInvalid = true, bool showInvalidMessage = true)
        {
            return new CoolInputOpt(text) { RepeatWhenInvalid = repeatWhenInvalid, ShowInvalidInputMsg = showInvalidMessage };
        }

        /// <summary>
        /// Creates a CoolInputOpt with the specified (CoolText) messages and the specified bool parameters.
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <param name="invalidInputMessage"></param>
        /// <param name="repeatWhenInvalid"></param>
        /// <param name="showInvalidMessage"></param>
        /// <returns></returns>
        public static CoolInputOpt InOpt(CoolText requestMessage, CoolText invalidInputMessage, bool repeatWhenInvalid = true, bool showInvalidMessage = true)
        {
            return new CoolInputOpt(requestMessage, invalidInputMessage) { RepeatWhenInvalid = repeatWhenInvalid, ShowInvalidInputMsg = showInvalidMessage };
        }

        /// <summary>
        /// Creates a CoolInputOpt with the specified (CoolText) messages in the tuple and the specified bool parameters.
        /// </summary>
        /// <param name="msgs">1 - requestMessage<para/>2 - invalidInputMessage</param>
        /// <param name="repeatWhenInvalid">repeatWhenInvalid</param>
        /// <param name="showInvalidMessage">showInvalidMessage</param>
        /// <returns></returns>
        public static CoolInputOpt InOpt(this (CoolText requestMessage, CoolText invalidInputMessage) msgs, bool repeatWhenInvalid = true, bool showInvalidMessage = true)
        {
            return new CoolInputOpt(msgs.requestMessage, msgs.invalidInputMessage) { RepeatWhenInvalid = repeatWhenInvalid, ShowInvalidInputMsg = showInvalidMessage };
        }


        /// <summary>
        /// Creates a CoolInputOpt with this CoolSnippet as the request message and the specified bool parameters.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="repeatWhenInvalid"></param>
        /// <param name="showInvalidMessage"></param>
        /// <returns></returns>
        public static CoolInputOpt InOpt(this CoolSnippet text, bool repeatWhenInvalid = true, bool showInvalidMessage = true)
        {
            return new CoolInputOpt((CoolText)text) { RepeatWhenInvalid = repeatWhenInvalid, ShowInvalidInputMsg = showInvalidMessage };
        }

        /// <summary>
        /// Creates a CoolInputOpt with the specified (CoolSnippet) messages and the specified bool parameters.
        /// </summary>
        /// <param name="requestMessage"></param>
        /// <param name="invalidInputMessage"></param>
        /// <param name="repeatWhenInvalid"></param>
        /// <param name="showInvalidMessage"></param>
        /// <returns></returns>
        public static CoolInputOpt InOpt(CoolSnippet requestMessage, CoolSnippet invalidInputMessage, bool repeatWhenInvalid = true, bool showInvalidMessage = true)
        {
            return new CoolInputOpt((CoolText)requestMessage, (CoolText)invalidInputMessage) { RepeatWhenInvalid = repeatWhenInvalid, ShowInvalidInputMsg = showInvalidMessage };
        }

        /// <summary>
        /// Creates a CoolInputOpt with the specified (CoolSnippet) messages in the tuple and the specified bool parameters.
        /// </summary>
        /// <param name="msgs">1 - requestMessage<para/>2 - invalidInputMessage</param>
        /// <param name="repeatWhenInvalid">repeatWhenInvalid</param>
        /// <param name="showInvalidMessage">showInvalidMessage</param>
        /// <returns></returns>
        public static CoolInputOpt InOpt(this (CoolSnippet requestMessage, CoolSnippet invalidInputMessage) msgs, bool repeatWhenInvalid = true, bool showInvalidMessage = true)
        {
            return new CoolInputOpt((CoolText)msgs.requestMessage, (CoolText)msgs.invalidInputMessage) { RepeatWhenInvalid = repeatWhenInvalid, ShowInvalidInputMsg = showInvalidMessage };
        }
    }
}