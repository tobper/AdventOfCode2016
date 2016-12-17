using System;
using System.Collections.Generic;

namespace AdventOfCode.Day6_Signals_and_Noise
{
    public class Day6
    {
        public static string Part1(IEnumerable<string> input)
        {
            var counter = CountLetters(input);
            var letters = counter.GetMostCommonLetters();
            var result = new string(letters);

            return result;
        }

        public static string Part2(IEnumerable<string> input)
        {
            var counter = CountLetters(input);
            var letters = counter.GetLeastCommonLetters();
            var result = new string(letters);

            return result;
        }

        private static LetterCounter CountLetters(IEnumerable<string> input)
        {
            var counter = new LetterCounter();

            foreach (var line in input)
            {
                for (var position = 0; position < line.Length; position++)
                {
                    counter.AddLetter(position, line[position]);
                }
            }

            return counter;
        }
    }
}
