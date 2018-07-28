using System;
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
        [InlineData(new int[] {1, 2}, 5)]
        [InlineData(new int[] {2, 3, 4}, 29)]
        [InlineData(new int[] {5, 6, 7}, 110)]
        [InlineData(new int[] {3, 4, 5}, 50)]
        public void SquareSumTest(int[] value, int expected)
        {
            var result = _cwk.SquareSum(value);
            Assert.Equal(expected, result);
        }
    }
}
