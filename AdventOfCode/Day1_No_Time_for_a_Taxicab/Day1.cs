using AdventOfCode.Day1_No_Time_for_a_Taxicab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode.Day1_No_Time_for_a_Taxicab
{
    public static class Day1
    {
        public static int Part1(string input)
        {
            return Walk<Walker>(input);
        }

        public static int Part2(string input)
        {
            try
            {
                Walk<LoggedWalker>(input);
            }
            catch (AlreadyVisitedException e)
            {
                return GetDistance(e.X, e.Y);
            }

            throw new InvalidOperationException("No location was visited twice.");
        }

        private static int Walk<TWalker>(string input) where TWalker : Walker, new()
        {
            var instructions = ParseInstructions(input);
            var walker = new TWalker();

            foreach (var instruction in instructions)
            {
                var turn = instruction[0];
                var steps = int.Parse(instruction.Substring(1));

                switch (turn)
                {
                    case 'R': walker.TurnRight(); break;
                    case 'L': walker.TurnLeft(); break;
                }

                walker.Walk(steps);
            }

            return GetDistance(walker.X, walker.Y);
        }

        private static int GetDistance(int x, int y)
        {
            return Math.Abs(x) + Math.Abs(y);
        }

        static IEnumerable<string> ParseInstructions(string input)
        {
            return Regex.
                Matches(input, "[RL]\\d+").
                Cast<Match>().
                Select(m => m.Value);
        }
    }
}