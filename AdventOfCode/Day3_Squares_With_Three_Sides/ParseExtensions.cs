using System;
using System.Linq;

namespace AdventOfCode.Day3_Squares_With_Three_Sides
{

    static class ParseExtensions
    {
        static char[] NumberSeparators = " ".ToCharArray();

        public static int[][] ParseNumbers(this string[] lines)
        {
            return lines.
                Select(line =>
                {
                    return line.
                        Split(NumberSeparators, StringSplitOptions.RemoveEmptyEntries).
                        Select(number => int.Parse(number)).
                        ToArray();
                }).
                ToArray();
        }
    }
}
