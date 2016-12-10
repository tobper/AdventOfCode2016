using AdventOfCode.Day2_Bathroom_Security.Models;

namespace AdventOfCode.Day2_Bathroom_Security
{

    public class Day2
    {
        public static string Part1(string[] instructions)
        {
            return Execute<ClassicKeyPad>(instructions);
        }

        public static string Part2(string[] instructions)
        {
            return Execute<StarKeyPad>(instructions);
        }

        private static string Execute<TKeyPad>(string[] instructions) where TKeyPad : IKeyPad, new()
        {
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
    }
}
