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

        private delegate void Printer(string str);

        private static void Main()
        {
            Joiner joiner = new Joiner("The first String!");

            Printer stringPrinter = PrintUpper;
            stringPrinter += PrintLower;
            stringPrinter += joiner.JoinAndPrint;

            stringPrinter("The second String!");
        }
    }
}
