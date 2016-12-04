using AdventOfCode.Day3_Squares_With_Three_Sides;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class Day3Tests
    {
        [TestMethod]
        [DataRow("5 10 25", 0)]
        [DataRow("5 20 25", 0)]
        [DataRow("6 20 25", 1)]
        [DataRow("1 2 3\r\n2 3 4\r\n3 4 6", 2)]
        public void TestDay3Part1(string input, int answer)
        {
            Day3.
                Part1(input).
                ShouldBeEquivalentTo(answer);
        }

        [TestMethod]
        [DataRow("1 2 3\r\n1 2 3\r\n1 2 3", 3)]
        public void TestDay3Part2(string input, int answer)
        {
            Day3.
                Part2(input).
                ShouldBeEquivalentTo(answer);
        }
    }
}
