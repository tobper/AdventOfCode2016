namespace AdventOfCode.Day5_How_About_a_Nice_Game_of_Chess
{
    public class Day5
    {
        public static string Part1(string doorId)
        {
            var hashGenerator = new OrderedPasswordGenerator(doorId);
            var password = hashGenerator.GetPassword();

            return password;
        }

        public static string Part2(string doorId)
        {
            var hashGenerator = new SortedPasswordGenerator(doorId);
            var password = hashGenerator.GetPassword();

            return password;
        }
    }
}
