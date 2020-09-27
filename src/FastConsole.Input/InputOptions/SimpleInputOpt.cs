namespace FastConsole
{
    /// <summary>
    /// A simple implementation of IInputOptions
    /// </summary>
    public class SimpleInputOpt : IInputOptions
    {
        #region Constructors
        /// <summary>
        /// Creates a SimpleInputOpt.
        /// </summary>
        public SimpleInputOpt()
        {

        }

        /// <summary>
        /// Creates a SimpleInputOpt with the specified parameters.
        /// </summary>
        /// <param name="requestMessage">The message to be printed when 'InvalidInputMessage()' is called.</param>
        /// <returns></returns>
        public SimpleInputOpt(string requestMessage) : this()
        {
            RequestMsg = requestMessage;
        }

        /// <summary>
        /// Creates a SimpleInputOpt with the specified parameters.
        /// </summary>
        /// <param name="requestMessage">The message to be printed when 'InvalidInputMessage()' is called.</param>
        /// <param name="invalidInputMessage">The message to be printed when 'InvalidInputMessage()' is called.</param>
        /// <returns></returns>
        public SimpleInputOpt(string requestMessage, string invalidInputMessage) : this(requestMessage)
        {
            InvalidInputMsg = invalidInputMessage;
        }
        #endregion

        /// <summary>
        /// The default InvalidInputMessage for new instances of SimpleInputOpt.
        /// </summary>
        /// <value></value>
        public static string Default_InvalidInputMsg { protected get; set; } = "The value is invalid!\n";

        #region Props
        /// <summary>
        /// The message to be printed when 'InvalidInputMessage()' is called.
        /// </summary>
        /// <value></value>
        public string RequestMsg { get; set; } = "Enter the value: ";

        /// <summary>
        /// The message to be printed when 'InvalidInputMessage()' is called.
        /// </summary>
        /// <value></value>
        public string InvalidInputMsg { get; set; } = Default_InvalidInputMsg;

        /// <summary>
        /// If, in cases of invalid input, you want 'InvalidInputMessage()' to be invoked.<para/>
        /// The default is true.
        /// </summary>
        /// <value></value>
        public bool ShowInvalidInputMsg { get; set; } = true;

        /// <summary>
        /// If, in cases of invalid input, you want the request to repeat until input is valid.<para/>
        /// The default is true.
        /// </summary>
        /// <value></value>
        public bool RepeatWhenInvalid { get; set; } = true;
        #endregion

        /// <summary>
        /// Prints the 'invalidInputMessage'.
        /// </summary>
        public void PrintInvalidInputMsg()
        {
            Out.Print(InvalidInputMsg);
        }

        /// <summary>
        /// Prints the 'requestMessage'.
        /// </summary>
        public void PrintRequestMsg()
        {
            Out.Print(RequestMsg);
        }

        /// <summary>
        /// Changes the RequestMsg and returns this SimpleInputOpt.
        /// </summary>
        /// <param name="requestMsg"></param>
        /// <returns></returns>
        public SimpleInputOpt SetMsg(string requestMsg)
        {
            this.RequestMsg = requestMsg;
            return this;
        }
        
        /// <summary>
        /// Changes the RequestMsg and the InvalidInputMsg and returns this SimpleInputOpt.
        /// </summary>
        /// <param name="requestMsg"></param>
        /// <param name="invalidInputMsg"></param>
        /// <returns></returns>
        public SimpleInputOpt SetMsg(string requestMsg, string invalidInputMsg)
        {
            this.RequestMsg = requestMsg;
            this.InvalidInputMsg = invalidInputMsg;
            return this;
        }

        #region Operators
        /// <summary>
        /// Returns a: <c>new SimpleInput(requestMessage);</c>
        /// </summary>
        /// <param name="requestMessage"></param>
        public static explicit operator SimpleInputOpt(string requestMessage)
        {
            return new SimpleInputOpt(requestMessage);
        }
        #endregion
    }
}