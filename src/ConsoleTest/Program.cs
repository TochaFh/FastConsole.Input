using System.Globalization;
using FastConsole;
using static System.ConsoleColor;

namespace ConsoleTest
{
    class Program : SimpleInputOpt
    {
        static void Main(string[] args)
        {
            Out.Println("Hello, world!");

            var opts = new SimpleInputOpt("Enter your age: ", "You must digit a valid number!\n");

            int age = In.ReadInt(opts).Value;
            float height = In.ReadFloat(opts.SetMsg("Enter your height: ")).Value;

            Out.Println($"You are age years old and your height is {height} m");
        }
    }
}
