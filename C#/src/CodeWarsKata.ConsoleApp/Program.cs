using System;
using CodeWarsKata.ClassLib;

namespace CodeWarsKata.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Code Wars Kata Solutions";

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("\tCodeWars Kata Solutions        ");
            Console.ResetColor();
            Console.WriteLine(Environment.NewLine);

            // CodeWarsKata cwk = new CodeWarsKata();
            CodeWarsKataFunctions cwk = new CodeWarsKataFunctions();

            // Square Sum
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("SquareSum: {0} - (1, 2)\n", cwk.SquareSum(new int[] {1, 2}));
            Console.Write("SquareSum: {0} - (2, 3, 4)\n", cwk.SquareSum(new int[] { 2, 3, 4 }));
            Console.Write("SquareSum: {0} - (5, 6, 7)\n", cwk.SquareSum(new int[] { 5, 6, 7 }));
            Console.Write("SquareSum: {0} - (3, 4, 5)\n\n", cwk.SquareSum(new int[] { 3, 4, 5 }));

            //Multiply
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Multiply: {0} - (1, 2)\n", cwk.Multiply(1, 2));
            Console.Write("Multiply: {0} - (5, 6)\n", cwk.Multiply(5, 6));
            Console.Write("Multiply: {0} - (45, 50)\n", cwk.Multiply(45, 50));
            Console.Write("Multiply: {0} - (4, 300)\n\n", cwk.Multiply(4, 300));

            //Min
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Min: {0} - (1, 2, 3, -4, 5)\n", cwk.FindSmallestInteger(new int[] { 1, 2, 3, -4, 5 }));
            Console.Write("Min: {0} - (1, -2, 3, -4, -50)\n", cwk.FindSmallestInteger(new int[] { 1, -2, 3, -4, -50 }));
            Console.Write("Min: {0} - (1, 20, 83, -74, 5)\n", cwk.FindSmallestInteger(new int[] { 1, 20, 83, -74, 5 }));
            Console.Write("Min: {0} - (-1, 20, 33, 45, 56)\n\n", cwk.FindSmallestInteger(new int[] { -1, 20, 33, 45, 56 }));

            //Shortest Word
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Shortest Word: {0} - (\"Hello now brown cow!\")\n", cwk.FindShort("Hello now brown cow!"));
            Console.Write("Shortest Word: {0} - (\"Hello, I love you won't you tell me your name!\")\n", cwk.FindShort("Hello, I love you won't you tell me your name!"));
            Console.Write("Shortest Word: {0} - (\"You say goodbye and I say Hello!\")\n", cwk.FindShort("You say goodbye and I say Hello!"));
            Console.Write("Shortest Word: {0} - (\"Raining blood!!\")\n\n", cwk.FindShort("Raining blood!"));

            Console.ReadKey();
        }
    }
}
