using AdventOfCode.Day6_Signals_and_Noise;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class Day6Tests
    {
        [TestMethod]
        [DataRow(new[] { "eedadn", "drvtee", "eandsr", "raavrd", "atevrs", "tsrnev", "sdttsa", "rasrtv", "nssdts", "ntnada", "svetve", "tesnvt", "vntsnd", "vrdear", "dvrsen", "enarar" }, "easter")]
        public void TestDay6Part1(string[] input, string answer)
        {
            Day6.
                Part1(input).
                ShouldBeEquivalentTo(answer);
        }

        [TestMethod]
        [DataRow(new[] { "eedadn", "drvtee", "eandsr", "raavrd", "atevrs", "tsrnev", "sdttsa", "rasrtv", "nssdts", "ntnada", "svetve", "tesnvt", "vntsnd", "vrdear", "dvrsen", "enarar" }, "advent")]
        public void TestDay6Part2(string[] input, string answer)
        {
            Day6.
                Part2(input).
                ShouldBeEquivalentTo(answer);
        }
    }
}
