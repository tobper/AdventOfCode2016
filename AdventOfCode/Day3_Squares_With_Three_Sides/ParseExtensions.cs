using System;
using System.Linq;

namespace AdventOfCode.Day3_Squares_With_Three_Sides
{

    static class ParseExtensions
    {
        static char[] LineSeparators = "\r\n".ToCharArray();
        static char[] NumberSeparators = " ".ToCharArray();

        public static int[][] ParseNumbers(this string input)
        {
            return input.
                Split(LineSeparators, StringSplitOptions.RemoveEmptyEntries).
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
