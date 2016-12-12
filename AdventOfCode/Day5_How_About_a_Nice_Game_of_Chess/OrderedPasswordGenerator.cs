using System.Linq;

namespace AdventOfCode.Day5_How_About_a_Nice_Game_of_Chess
{
    class OrderedPasswordGenerator : PasswordGenerator
    {
        public OrderedPasswordGenerator(string doorId) : base(doorId)
        {
        }

        public string GetPassword()
        {
            var characters = GetValidHashes().
                Select(hash => hash[5]).
                Take(8).
                ToArray();

            return new string(characters);
        }
    }
}
