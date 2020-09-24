using FastConsole;
using static System.ConsoleColor;

namespace ConsoleTest
{
    class Program : SimpleInputOpt
    {
        static void Main(string[] args)
        {
            Out.Println("Hello, world!");

            int input = In.ReadInt("Your age: ".InputOpt()).Value;

            Out.Println($"A entrada foi boa: '{input}'");
        }
    }
}
