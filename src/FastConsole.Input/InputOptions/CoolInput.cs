using static System.ConsoleColor;

namespace FastConsole
{
    /// <summary>
    /// A simple implementation of IInputOptions
    /// </summary>
    public class CoolInputOpt : IInputOptions
    {
        #region Constructors
        /// <summary>
        /// Creates a CoolInputOpt.
        /// </summary>
        public CoolInputOpt()
        {
            RequestMsg = (CoolText)"Enter the value: ".I(Cyan);
            InvalidMsg = (CoolText)"The value is invalid!\n".I(Red);
        }

        /// <summary>
        /// Creates a CoolInputOpt with the specified parameters.
        /// </summary>
        /// <param name="requestMessage">The message to be printed when 'InvalidInputMessage()' is called.</param>
        /// <returns></returns>
        public CoolInputOpt(CoolText requestMessage)
        {
            RequestMsg = requestMessage;
            InvalidMsg = (CoolText)"The value is invalid!\n".I(Red);
        }

        /// <summary>
        /// Creates a CoolInputOpt with the specified parameters.
        /// </summary>
        /// <param name="requestMessage">The message to be printed when 'InvalidInputMessage()' is called.</param>
        /// <param name="invalidInputMessage">The message to be printed when 'InvalidInputMessage()' is called.</param>
        /// <returns></returns>
        public CoolInputOpt(CoolText requestMessage, CoolText invalidInputMessage)
        {
            RequestMsg = requestMessage;
            InvalidMsg = invalidInputMessage;
        }
        #endregion

        /// <summary>
        /// The message to be printed when 'InvalidInputMessage()' is called.
        /// </summary>
        /// <value></value>
        protected CoolText RequestMsg { get; set; }

        /// <summary>
        /// The message to be printed when 'InvalidInputMessage()' is called.
        /// </summary>
        /// <value></value>
        protected CoolText InvalidMsg { get; set; }

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
        /// Returns a: <c>new CoolInput(requestMessage);</c>
        /// </summary>
        /// <param name="requestMessage"></param>
        public static explicit operator CoolInputOpt(CoolText requestMessage)
        {
            return new CoolInputOpt(requestMessage);
        }

        /// <summary>
        /// Returns a: <c>new CoolInput(requestMessage);</c>
        /// </summary>
        /// <param name="requestMessage"></param>
        public static explicit operator CoolInputOpt(CoolSnippet requestMessage)
        {
            return new CoolInputOpt((CoolText)requestMessage);
        }
    }
}