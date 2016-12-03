using AdventOfCode.Day2_Bathroom_Security.Models;
using System;

namespace AdventOfCode.Day2_Bathroom_Security
{

    public class Day2
    {
        public static string Part1(string input)
        {
            return Execute<ClassicKeyPad>(input);
        }

        public static string Part2(string input)
        {
            return Execute<StarKeyPad>(input);
        }

        private static string Execute<TKeyPad>(string input) where TKeyPad : IKeyPad, new()
        {
            var instructions = ParseInstructions(input);
            var keyPad = new TKeyPad();
            var result = "";

            foreach (var instruction in instructions)
            {
                foreach (var move in instruction)
                {
                    switch (move)
                    {
                        case 'D': keyPad.Down(); break;
                        case 'L': keyPad.Left(); break;
                        case 'R': keyPad.Right(); break;
                        case 'U': keyPad.Up(); break;
                    }
                }

                result += keyPad.Key;
            }

            return result;
        }

        private static string[] ParseInstructions(string input)
        {
            return input.Split(
                "\r\n".ToCharArray(),
                StringSplitOptions.RemoveEmptyEntries);
        }
    }
}
