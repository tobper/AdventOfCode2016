using AdventOfCode.Day1_No_Time_for_a_Taxicab;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class Day1Tests
    {
        [TestMethod]
        [DataRow("R2, L3", 5)]
        [DataRow("R2, R2, R2", 2)]
        [DataRow("R5, L5, R5, R3", 12)]
        public void TestDay1Part1(string input, int answer)
        {
            Day1.
                Part1(input).
                ShouldBeEquivalentTo(answer);
        }

        [TestMethod]
        [DataRow("R8, R4, R4, R8", 4)]
        public void TestDay1Part2(string input, int answer)
        {
            Day1.
                Part2(input).
                ShouldBeEquivalentTo(answer);
        }
    }
}
