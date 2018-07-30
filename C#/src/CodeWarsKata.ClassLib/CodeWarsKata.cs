using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWarsKata.ClassLib
{
    public class CodeWarsKataFunctions
    {

        public int ExpressionsMatter(int a, int b, int c)
        {
            return Math.Max(a * (b + c), Math.Max(a * b * c, Math.Max( a + b * c, Math.Max((a + b) * c, a + b + c))));
        }

        public string FakeBin(string x)
        {
            string answer = "";
            foreach(char n in x.ToCharArray()) {
                if (Char.GetNumericValue(n) < 5) {
                    answer += "0";
                } else {
                    answer += "1";
                }
            }

            return answer;
        }

        public double FindAverage(double[] array)
        {
            if (array == null || array.Length == 0) return 0;
            return array.Sum(x => x) / array.Length;
        }

        public int FindShort(string s)
        {
            return s.Split(' ').Min(x => x.Length);
        }

        public int FindSmallestInteger(int[] n)
        {
            return n.Min();
        }

        public string greet()
        {
            string hex = "68 65 6c 6c 6f 20 77 6f 72 6c 64",
                   answer = "";

            foreach (string h in hex.Split(' '))
            {
                int hv = Convert.ToInt32(h, 16);
                string sv = Char.ConvertFromUtf32(hv);
                answer += sv;
            }

            return answer;
        }

        public int MakeNegative(int number)
        {
            return number < 0 ? number : -number;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Opposite(int number)
        {
            return -number;
        }

        public int PositiveSum(int[] arr)
        {
            return (from n in arr where n > 0 select n).Sum();
        }

        public List<int> RemoveSmallest(List<int> numbers)
        {
            if (!numbers.Any()) return numbers;

            var num = numbers.Min();
            numbers.Remove(num);
            return numbers;
        }

        public string repeatStr(int n, string s)
        {
            string answer = "";
            for (; n > 0; n--)
            {
                answer += s;
            }

            return answer;
        }

        public string ReverseWords(string str)
        {
            string[] arr = str.Split(' ');
            string final = "";

            foreach (string w in arr)
            {
                char[] rev = w.Reverse().ToArray();

                foreach (char l in rev)
                {
                    final += l;
                }
                final += " ";
            }
            return final.Trim();
        }

        public int SquareSum(int[] n)
        {
            int total = 0;
            foreach (int num in n)
            {
                total += (int)Math.Pow(num, 2);
            }

            return total;
        }

        public int Summation(int num)
        {
            return Enumerable.Range(0, num + 1).Sum();
        }

        public string SwitchItUp(int number)
        {
            return new Dictionary<int, string> {{ 1, "One" },
                                                { 2, "Two"},
                                                { 3, "Three"},
                                                { 4, "Four"},
                                                { 5, "Five"},
                                                { 6, "Six"},
                                                { 7, "Seven"},
                                                { 8, "Eight"},
                                                { 9, "Nine"},
                                                { 0, "Zero"}}[number];
        }
    }
}
