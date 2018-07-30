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

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\t    CodeWars Kata Solutions    ");
            Console.ResetColor();
            Console.WriteLine(Environment.NewLine);
            Console.ResetColor();

            CodeWarsKataFunctions cwk = new CodeWarsKataFunctions();

            //Expressions Matter
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Expressions Matter: {0}\n", cwk.ExpressionsMatter(2, 1, 2));
            Console.Write("Expressions Matter: {0}\n", cwk.ExpressionsMatter(1, 1, 1));
            Console.Write("Expressions Matter: {0}\n\n", cwk.ExpressionsMatter(10, 05, 06));

            //Fake Binary
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Fake Binary: {0} - (\"0123456789\")\n", cwk.FakeBin("0123456789"));
            Console.Write("Fake Binary: {0} - (\"9126345078129\")\n", cwk.FakeBin("9126345078129"));
            Console.Write("Fake Binary: {0} - (\"85949039984572667471\")\n", cwk.FakeBin("85949039984572667471"));
            Console.Write("Fake Binary: {0} - (\"0594837264759860397215\")\n\n", cwk.FakeBin("0594837264759860397215"));

            //Find Average
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Find Average of 1, 2, 3: {0}\n", cwk.FindAverage(new double[] { 1, 2, 3 }));
            Console.Write("Find Average of 4, 5, 6, 28 , 2: {0}\n", cwk.FindAverage(new double[] { 4, 5, 6, 28, 2 }));
            Console.Write("Find Average of 56, 234, 655, 9: {0}\n\n", cwk.FindAverage(new double[] { 56, 234, 655, 9 }));

            //Find Shortest Word
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Shortest Word: {0} - (\"Hello now brown cow!\")\n", cwk.FindShort("Hello now brown cow!"));
            Console.Write("Shortest Word: {0} - (\"Hello, I love you won't you tell me your name!\")\n", cwk.FindShort("Hello, I love you won't you tell me your name!"));
            Console.Write("Shortest Word: {0} - (\"You say goodbye and I say Hello!\")\n", cwk.FindShort("You say goodbye and I say Hello!"));
            Console.Write("Shortest Word: {0} - (\"Raining blood!!\")\n\n", cwk.FindShort("Raining blood!"));

            //Min
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Min: {0} - (1, 2, 3, -4, 5)\n", cwk.FindSmallestInteger(new int[] { 1, 2, 3, -4, 5 }));
            Console.Write("Min: {0} - (1, -2, 3, -4, -50)\n", cwk.FindSmallestInteger(new int[] { 1, -2, 3, -4, -50 }));
            Console.Write("Min: {0} - (1, 20, 83, -74, 5)\n", cwk.FindSmallestInteger(new int[] { 1, 20, 83, -74, 5 }));
            Console.Write("Min: {0} - (-1, 20, 33, 45, 56)\n\n", cwk.FindSmallestInteger(new int[] { -1, 20, 33, 45, 56 }));

            //Hello World
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Creative way to do \"hello world\": {0}\n\n", cwk.greet());

            //Make Negative
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Make Negative -1: {0}\n", cwk.MakeNegative(-1));
            Console.Write("Make Negative 5: {0}\n", cwk.MakeNegative(5));
            Console.Write("Make Negative 0: {0}\n\n", cwk.MakeNegative(0));

            //Multiply
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Multiply: {0} - (1, 2)\n", cwk.Multiply(1, 2));
            Console.Write("Multiply: {0} - (5, 6)\n", cwk.Multiply(5, 6));
            Console.Write("Multiply: {0} - (45, 50)\n", cwk.Multiply(45, 50));
            Console.Write("Multiply: {0} - (4, 300)\n\n", cwk.Multiply(4, 300));

            //Opposite
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Opposite of -1 is {0}\n", cwk.Opposite(-1));
            Console.Write("Opposite of 5 is {0}\n", cwk.Opposite(5));
            Console.Write("Opposite of 0 is {0}\n\n", cwk.Opposite(0));

            //Positive Sums
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Sum of Positive numbers (1, 2, 3, 4, 5) is {0}\n", cwk.PositiveSum(new int[] { 1, 2, 3, 4, 5 }));
            Console.Write("Sum of Positive numbers (1, -2, 3, 4, 5) is {0}\n", cwk.PositiveSum(new int[] { 1, -2, 3, 4, 5 }));
            Console.Write("Sum of Positive numbers (-1, 2, 3, 4, -5) is {0}\n", cwk.PositiveSum(new int[] { -1, 2, 3, 4, -5 }));
            Console.Write("Sum of Positive numbers () is {0}\n", cwk.PositiveSum(new int[] { }));
            Console.Write("Sum of Positive numbers (-1, -2, -3, -4, -5) is {0}\n\n", cwk.PositiveSum(new int[] { -1, -2, -3, -4, -5 }));

            //Remove Smallest in List
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Remove Smallest: {0}\n", string.Join(", ", cwk.RemoveSmallest(new List<int> { 1, 2, 3, 4, 5 })));
            Console.Write("Remove Smallest: {0}\n", string.Join(", ", cwk.RemoveSmallest(new List<int> { 10, -2, 3, 4, 55, -400 })));
            Console.Write("Remove Smallest: {0}\n", string.Join(", ", cwk.RemoveSmallest(new List<int> { 2, 2, 1, 2, 1 })));
            Console.Write("Remove Smallest: {0} -EMPTY LIST-\n\n", string.Join(", ", cwk.RemoveSmallest(new List<int>())));

            //Repeat String
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("Repeat String Hello 6x: {0}\n", cwk.repeatStr(6, "Hello"));
            Console.Write("Repeat String I 10x: {0}\n\n", cwk.repeatStr(10, "I"));

            //Reverse Words
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Reverse of Hello World is: {0}\n", cwk.ReverseWords("Hello World"));
            Console.Write("Reverse of I love you is: {0}\n", cwk.ReverseWords("I love you"));
            Console.Write("Reverse of Lucille is so beautiful! is: {0}\n\n", cwk.ReverseWords("Lucille is so beautiful!"));

            // Square Sum
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("SquareSum: {0} - (1, 2)\n", cwk.SquareSum(new int[] {1, 2}));
            Console.Write("SquareSum: {0} - (2, 3, 4)\n", cwk.SquareSum(new int[] { 2, 3, 4 }));
            Console.Write("SquareSum: {0} - (5, 6, 7)\n", cwk.SquareSum(new int[] { 5, 6, 7 }));
            Console.Write("SquareSum: {0} - (3, 4, 5)\n\n", cwk.SquareSum(new int[] { 3, 4, 5 }));

            //Summation
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Summation of 1: {0}\n", cwk.Summation(1));
            Console.Write("Summation of 22: {0}\n", cwk.Summation(22));
            Console.Write("Summation of 100: {0}\n\n", cwk.Summation(100));

            //Switch It Up
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Switch It Up 1: {0}\n", cwk.SwitchItUp(1));
            Console.Write("Switch It Up 5: {0}\n\n", cwk.SwitchItUp(5));

            Console.ReadKey();
        }
    }
}
