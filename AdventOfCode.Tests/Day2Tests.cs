using AdventOfCode.Day2_Bathroom_Security;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class Day2Tests
    {
        [TestMethod]
        [DataRow(new[] { "ULL", "RRDDD", "LURDL", "UUUUD" }, "1985")]
        public void TestDay2Part1(string[] input, string answer)
        {
            Day2.
                Part1(input).
                ShouldBeEquivalentTo(answer);
        }

        [TestMethod]
        [DataRow(new[] { "ULL", "RRDDD", "LURDL", "UUUUD" }, "5DB3")]
        public void TestDay2Part2(string[] input, string answer)
        {
            Day2.
                Part2(input).
                ShouldBeEquivalentTo(answer);
        }
    }
}
