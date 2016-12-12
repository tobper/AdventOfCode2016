using System.Globalization;
using System.Linq;

namespace AdventOfCode.Day5_How_About_a_Nice_Game_of_Chess
{
    class SortedPasswordGenerator : PasswordGenerator
    {
        public SortedPasswordGenerator(string doorId) : base(doorId)
        {
        }

        public string GetPassword()
        {
            var characters = new char[8];

            foreach (var hash in GetValidHashes())
            {
                var position = GetPasswordCharacterPosition(hash);
                if (position >= 8 || PasswordCharacterIsDefined(characters, position))
                    continue;

                characters[position] = hash[6];

                if (PasswordIsCompleted(characters))
                    break;
            }

            return new string(characters);
        }

        private static int GetPasswordCharacterPosition(string hash)
        {
            return int.Parse($"{hash[5]}", NumberStyles.AllowHexSpecifier);
        }

        private static bool PasswordCharacterIsDefined(char[] characters, int position)
        {
            return characters[position] != 0;
        }

        private static bool PasswordIsCompleted(char[] characters)
        {
            return characters.All(c => c != 0);
        }
    }
}
