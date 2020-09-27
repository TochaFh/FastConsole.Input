using FastConsole;
using static System.ConsoleColor;

namespace ConsoleTest
{
    class Program : SimpleInputOpt
    {
        static void Main(string[] args)
        {
            var opts = new SimpleInputOpt("Enter your age: ", "You must digit a valid number!\n");

            int age = In.ReadInt(opts).Value;
            float height = In.ReadFloat(opts.SetMsg("Enter your height: ")).Value;

            Out.Println($"You are {age} years old and your height is {height}m!\n");

            string[] words = In.ReadInput<string[]>(opts.SetMsg("Enter your favorite words: "), GetWords);

            Out.Println("\nYour favorite words are:");

            foreach (var word in words)
            {
                Out.Println("- " + word.I(Red));
            }
        }

        static string[] GetWords(string input)
        {
            return string.IsNullOrWhiteSpace(input) ? new string[0] : input.Split(input);
        }
    }
}