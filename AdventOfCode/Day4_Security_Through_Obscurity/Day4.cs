using System.Linq;

namespace AdventOfCode.Day4_Security_Through_Obscurity
{
    public class Day4
    {
        public static int Part1(params string[] lines)
        {
            var sectorIds =
                from line in lines
                let room = Room.Parse(line)
                where room.IsReal()
                select room.SectorId;

            return sectorIds.Sum();
        }

        public static int Part2(params string[] lines)
        {
            return Part2("northpole object storage", lines);
        }

        public static int Part2(string decryptedName, params string[] lines)
        {
            return lines.
                Select(line => Room.Parse(line)).
                Where(room => room.IsReal()).
                Where(room => room.GetDecryptedName() == decryptedName).
                Select(room => room.SectorId).
                FirstOrDefault();
        }
    }
}
