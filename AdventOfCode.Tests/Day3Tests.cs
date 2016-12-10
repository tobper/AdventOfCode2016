using AdventOfCode.Day3_Squares_With_Three_Sides;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class Day3Tests
    {
        [TestMethod]
        [DataRow(new[] { "5 10 25" }, 0)]
        [DataRow(new[] { "5 20 25" }, 0)]
        [DataRow(new[] { "6 20 25" }, 1)]
        [DataRow(new[] { "1 2 3", "2 3 4", "3 4 6" }, 2)]
        public void TestDay3Part1(string[] input, int answer)
        {
            Day3.
                Part1(input).
                ShouldBeEquivalentTo(answer);
        }

        [TestMethod]
        [DataRow(new[] { "1 2 3", "1 2 3", "1 2 3" }, 3)]
        public void TestDay3Part2(string[] input, int answer)
        {
            Day3.
                Part2(input).
                ShouldBeEquivalentTo(answer);
        }
    }
}
