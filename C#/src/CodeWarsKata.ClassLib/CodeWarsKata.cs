using System;
using System.Linq;

namespace CodeWarsKata.ClassLib
{
    public class CodeWarsKataFunctions
    {
        public int SquareSum(int[] n) {
            int total = 0;
            foreach (int num in n) {
                total += (int)Math.Pow(num, 2);
            }

            return total;
        }

        public int Multiply(int a, int b) {
            return a * b;
        }

        public int FindSmallestInteger(int[] n) {
            return n.Min();
        }

        public int FindShort(string s) {
            return s.Split(' ').Min(x => x.Length);
        }
    }
}
