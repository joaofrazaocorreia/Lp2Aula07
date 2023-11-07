using System;

namespace Delegates
{
    class Program
    {
        private static void PrintUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        private static void PrintLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }

        private static void Main()
        {
            Joiner joiner = new Joiner("The first String!");

            Action<string> stringPrinter = PrintUpper;
            stringPrinter += PrintLower;
            stringPrinter += joiner.JoinAndPrint;

            stringPrinter("The second String!");
        }
    }
}
