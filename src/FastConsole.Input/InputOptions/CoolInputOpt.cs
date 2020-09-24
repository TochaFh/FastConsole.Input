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
            InvalidInputMsg = Default_InvalidInputMsg;
        }

        /// <summary>
        /// Creates a CoolInputOpt with the specified parameters.
        /// </summary>
        /// <param name="requestMessage">The message to be printed when 'InvalidInputMessage()' is called.</param>
        /// <returns></returns>
        public CoolInputOpt(CoolText requestMessage)
        {
            RequestMsg = requestMessage;
            InvalidInputMsg = Default_InvalidInputMsg;
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
            InvalidInputMsg = invalidInputMessage;
        }
        #endregion

        /// <summary>
        /// The default InvalidInputMessage for new instances of CoolInputOpt.
        /// </summary>
        /// <value></value>
        public static CoolText Default_InvalidInputMsg { protected get; set; } = (CoolText)"The value is invalid!\n".I(Red);

        #region Props
        /// <summary>
        /// The message to be printed when 'InvalidInputMessage()' is called.
        /// </summary>
        /// <value></value>
        protected CoolText RequestMsg { get; set; }

        /// <summary>
        /// The message to be printed when 'InvalidInputMessage()' is called.
        /// </summary>
        /// <value></value>
        protected CoolText InvalidInputMsg { get; set; }

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
        /// Changes the RequestMsg and rturns this CoolInputOpt.
        /// </summary>
        /// <param name="requestMsg"></param>
        /// <returns></returns>
        public CoolInputOpt SetMsg(CoolText requestMsg)
        {
            this.RequestMsg = requestMsg;
            return this;
        }
        
        /// <summary>
        /// Changes the RequestMsg and the InvalidInputMsg and rturns this CoolInputOpt.
        /// </summary>
        /// <param name="requestMsg"></param>
        /// <param name="invalidInputMsg"></param>
        /// <returns></returns>
        public CoolInputOpt SetMsg(CoolText requestMsg, CoolText invalidInputMsg)
        {
            this.RequestMsg = requestMsg;
            this.InvalidInputMsg = invalidInputMsg;
            return this;
        }

        #region Operators
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
        #endregion
    }
}