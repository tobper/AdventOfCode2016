using AdventOfCode.Day5_How_About_a_Nice_Game_of_Chess;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class Day5Tests
    {
        [TestMethod]
        [DataRow("abc", "18f47a30")]
        public void TestDay5Part1(string doorId, string answer)
        {
            Day5.
                Part1(doorId).
                ShouldBeEquivalentTo(answer);
        }

        [TestMethod]
        [DataRow("abc", "05ace8e3")]
        public void TestDay5Part2(string doorId, string answer)
        {
            Day5.
                Part2(doorId).
                ShouldBeEquivalentTo(answer);
        }
    }
}
