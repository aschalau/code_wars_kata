using System;
using System.Collections.Generic;
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

            //Fake Binary
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Fake Binary: {0} - (\"0123456789\")\n", cwk.FakeBin("0123456789"));
            Console.Write("Fake Binary: {0} - (\"9126345078129\")\n", cwk.FakeBin("9126345078129"));
            Console.Write("Fake Binary: {0} - (\"85949039984572667471\")\n", cwk.FakeBin("85949039984572667471"));
            Console.Write("Fake Binary: {0} - (\"0594837264759860397215\")\n\n", cwk.FakeBin("0594837264759860397215"));

            //Remove Smallest in List
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Remove Smallest: {0}\n", string.Join(", ", cwk.RemoveSmallest(new List<int> { 1, 2, 3, 4, 5 })));
            Console.WriteLine("Remove Smallest: {0}\n", string.Join(", ", cwk.RemoveSmallest(new List<int> { 10, -2, 3, 4, 55, -400 })));
            Console.WriteLine("Remove Smallest: {0}\n", string.Join(", ", cwk.RemoveSmallest(new List<int> { 2, 2, 1, 2, 1 })));
            Console.WriteLine("Remove Smallest: {0}\n\n", string.Join(", ", cwk.RemoveSmallest(new List<int>())));

            //Hello World
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(cwk.greet() + "\n");

            //Reverse Words
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Reverse of Hello World is: {0}\n", cwk.ReverseWords("Hello World"));
            Console.WriteLine("Reverse of I love you is: {0}\n", cwk.ReverseWords("I love you"));
            Console.WriteLine("Reverse of Lucille is so beautiful! is: {0}\n\n", cwk.ReverseWords("Lucille is so beautiful!"));

            //Switch It Up
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Switch It Up 1: {0}\n", cwk.SwitchItUp(1));
            Console.WriteLine("Switch It Up 5: {0}\n\n", cwk.SwitchItUp(5));

            //Find Average
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Find Average of 1, 2, 3: {0}\n", cwk.FindAverage(new double[] { 1, 2, 3 }));
            Console.WriteLine("Find Average of 4, 5, 6, 28 , 2: {0}\n", cwk.FindAverage(new double[] { 4, 5, 6, 28, 2 }));
            Console.WriteLine("Find Average of 56, 234, 655, 9: {0}\n\n", cwk.FindAverage(new double[] { 56, 234, 655, 9 }));

            //Make Negative
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Make Negative -1: {0}\n", cwk.MakeNegative(-1));
            Console.WriteLine("Make Negative 5: {0}\n", cwk.MakeNegative(5));
            Console.WriteLine("Make Negative 0: {0}\n\n", cwk.MakeNegative(0));

            //Repeat String
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Repeat String Hello 6x: {0}\n", cwk.repeatStr(6, "Hello"));
            Console.WriteLine("Repeat String I 10x: {0}\n\n", cwk.repeatStr(10, "I"));

            Console.ReadKey();
        }
    }
}
