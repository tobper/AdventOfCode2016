using AdventOfCode.Day4_Security_Through_Obscurity;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventOfCode.Tests
{
    [TestClass]
    public class Day4Tests
    {
        [TestMethod]
        [DataRow("aaaaa-bbb-z-y-x-123[abxyz]", 123)]
        [DataRow("a-b-c-d-e-f-g-h-987[abcde]", 987)]
        [DataRow("not-a-real-room-404[oarel]", 404)]
        [DataRow("totally-real-room-200[decoy]", 0)]
        public void TestDay4Part1(string input, int answer)
        {
            Day4.
                Part1(input).
                ShouldBeEquivalentTo(answer);
        }

        [TestMethod]
        [DataRow("qzmt-zixmtkozy-ivha-343[zimta]", 0)]
        [DataRow("qzmt-zixmtkozy-ivhz-343[zimth]", 343)]
        public void TestDay4Part2(string input, int answer)
        {
            Day4.
                Part2("very encrypted name", input).
                ShouldBeEquivalentTo(answer);
        }
    }
}
