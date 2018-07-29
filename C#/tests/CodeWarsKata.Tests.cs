// using System;
// using System.Collections.Generic;
using Xunit;
using CodeWarsKata.ClassLib;

namespace tests
{
    public class CodeWarsKata_Tests
    {
        private readonly CodeWarsKataFunctions _cwk;

        public CodeWarsKata_Tests() {
            _cwk = new CodeWarsKataFunctions();
        }

        [Theory]
        [InlineData("0123456789", "0000011111")]
        [InlineData("9126345078129", "1001001011001")]
        [InlineData("85949039984572667471", "11101001110110111010")]
        [InlineData("0594837264759860397215", "0110101010111110011001")]
        public void FakeBinaryTest(string value, string expected)
        {
            var result = _cwk.FakeBin(value);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new double[] { 1, 2, 3 }, 2)]
        [InlineData(new double[] { 4, 5, 6, 28, 2 }, 9)]
        [InlineData(new double[] { 56, 234, 655, 9 }, 238.5)]
        public void FindAverageTest(double[] value, double expected)
        {
            var result = _cwk.FindAverage(value);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Hello now brown cow!", 3)]
        [InlineData("Hello, I love you won't you tell me your name!", 1)]
        [InlineData("You say goodbye and I say Hello!", 1)]
        [InlineData("Raining blood!", 6)]
        public void FindShortTest(string value, int expected)
        {
            var result = _cwk.FindShort(value);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, -4, 5 }, -4)]
        [InlineData(new int[] { 1, -2, 3, -4, -50 }, -50)]
        [InlineData(new int[] { 1, 20, 83, -74, 5 }, -74)]
        [InlineData(new int[] { -1, 20, 33, 45, 56 }, -1)]
        public void FindSmallestIntegerTest(int[] value, int expected)
        {
            var result = _cwk.FindSmallestInteger(value);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void GreetTest()
        {
            var result = _cwk.greet();
            Assert.Equal("hello world", result);
        }

        [Theory]
        [InlineData(-1, -1)]
        [InlineData(5, -5)]
        [InlineData(0, 0)]
        public void MakeNegativeTest(int value, int expected)
        {
            var result = _cwk.MakeNegative(value);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(5, 6, 30)]
        [InlineData(45, 50, 2250)]
        [InlineData(4, 300, 1200)]
        public void MultiplyTest(int value1, int value2, int expected)
        {
            var result = _cwk.Multiply(value1, value2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 15)]
        [InlineData(new int[] { 1, -2, 3, 4, 5 }, 13)]
        [InlineData(new int[] { -1, 2, 3, 4, -5 }, 9)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new int[] { -1, -2, -3, -4, -5 }, 0)]
        public void PositiveSumTest(int[] value, int expected)
        {
            var result = _cwk.PositiveSum(value);
            Assert.Equal(expected, result);
        }

        // TODO: Figure out how to pass in List<int> or new List<int>
        //       Two using statemtents are commented out from this as well
        // [Theory]
        // [InlineData(List<int> {1, 2, 3, 4, 5}, List<int> {2, 3, 4, 5})]
        // [InlineData(List<int> {10, -2, 3, 4, 55, -400}, List<int> {10, -2, 3, 4, 55})]
        // [InlineData(List<int> {2, 2, 1, 2, 1}, List<int> {2, 2, 2, 1})]
        // [InlineData(List<int> {}, List<int> {})]
        // public void RemoveSmallestTest(List<int> value, List<int> expected)
        // {
        //     var result = _cwk.RemoveSmallest(value);
        //     Assert.Equal(expected, result);
        // }

        [Theory]
        [InlineData(6, "Hello", "HelloHelloHelloHelloHelloHello")]
        [InlineData(10, "I", "IIIIIIIIII")]
        public void repeatStrTest(int value1, string value2, string expected)
        {
            var result = _cwk.repeatStr(value1, value2);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("Hello World", "olleH dlroW")]
        [InlineData("I love you", "I evol uoy")]
        [InlineData("Lucille is so beautiful!", "ellicuL si os !lufituaeb")]
        public void ReverseWordsTest(string value, string expected)
        {
            var result = _cwk.ReverseWords(value);
            Assert.Equal(expected, result);
        }


        [Theory]
        [InlineData(new int[] {1, 2}, 5)]
        [InlineData(new int[] {2, 3, 4}, 29)]
        [InlineData(new int[] {5, 6, 7}, 110)]
        [InlineData(new int[] {3, 4, 5}, 50)]
        public void SquareSumTest(int[] value, int expected)
        {
            var result = _cwk.SquareSum(value);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1, "One")]
        [InlineData(5, "Five")]
        public void SwitchItUpTest(int value, string expected)
        {
            var result = _cwk.SwitchItUp(value);
            Assert.Equal(expected, result);
        }
    }
}
