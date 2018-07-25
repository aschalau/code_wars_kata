﻿using System;
using System.Collections.Generic;
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

        public string FakeBin(string x) {
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

        public List<int> RemoveSmallest(List<int> numbers)
        {
            if(!numbers.Any()) return numbers;

            var num = numbers.Min();
            numbers.Remove(num);
            return numbers;
        }

        public string greet() {
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
    }
}
