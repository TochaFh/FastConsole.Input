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
            InvalidMsg = invalidInputMessage;
        }
        #endregion

        /// <summary>
        /// The message to be printed when 'InvalidInputMessage()' is called.
        /// </summary>
        /// <value></value>
        protected string RequestMsg { get; set; } = "Enter the value: ";

        /// <summary>
        /// The message to be printed when 'InvalidInputMessage()' is called.
        /// </summary>
        /// <value></value>
        protected string InvalidMsg { get; set; } = "The value is invalid!\n";

        /// <summary>
        /// If, in cases of invalid input, you want 'InvalidInputMessage()' to be invoked.<para/>
        /// The default is true.
        /// </summary>
        /// <value></value>
        public bool ShowInvalidMessage { get; set; } = true;

        /// <summary>
        /// If, in cases of invalid input, you want the request to repeat until input is valid.<para/>
        /// The default is true.
        /// </summary>
        /// <value></value>
        public bool RepeatWhenInvalid { get; set; } = true;

        /// <summary>
        /// Prints the 'invalidInputMessage'.
        /// </summary>
        public void InvalidInputMessage()
        {
            Out.Print(InvalidMsg);
        }

        /// <summary>
        /// Prints the 'requestMessage'.
        /// </summary>
        public void RequestMessage()
        {
            Out.Print(RequestMsg);
        }

        /// <summary>
        /// Returns a: <c>new SimpleInput(requestMessage);</c>
        /// </summary>
        /// <param name="requestMessage"></param>
        public static explicit operator SimpleInputOpt(string requestMessage)
        {
            return new SimpleInputOpt(requestMessage);
        }
    }
}