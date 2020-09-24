namespace FastConsole
{
    /// <summary>
    /// Options for the Read...() method.
    /// RequestMessage and InvalidInputMessage.
    /// </summary>
    public interface IInputOptions
    {
        /// <summary>
        /// If, in cases of invalid input, you want 'InvalidInputMessage()' to be invoked.
        /// </summary>
        /// <value></value>
        bool ShowInvalidInputMsg { get; set; }

        /// <summary>
        /// If, in cases of invalid input, you want the request to repeat until input is valid.
        /// </summary>
        /// <value></value>
        bool RepeatWhenInvalid { get; set; }

        /// <summary>
        /// Prints a request message.
        /// It's called before the user enters the input.
        /// <para/>Example:
        /// <code>
        /// public void RequestMessage()
        /// {
        ///     Out.Print("Enter your name: ");
        /// }    
        /// </code>
        /// </summary>
        void PrintRequestMsg();

        /// <summary>
        /// Prints a message for an invalid input.
        /// It's called after the user enters the input, if it was invalid (failed conversion, etc) and 'RepeatWhenInvalid' is true.
        /// <para/>Example:
        /// <code>
        /// public void RequestMessage()
        /// {
        ///     Out.Print("You must digit a number!", ConsoleColor.Red);
        /// }    
        /// </code>
        /// </summary>
        void PrintInvalidInputMsg();
    }
}