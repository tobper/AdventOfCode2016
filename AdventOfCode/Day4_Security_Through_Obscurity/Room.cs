using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode.Day4_Security_Through_Obscurity
{
    class Room
    {
        public string EncryptedName { get; private set; }
        public int SectorId { get; private set; }
        public string Checksum { get; private set; }

        private Room(string letters, int sectorId, string checksum)
        {
            EncryptedName = letters;
            SectorId = sectorId;
            Checksum = checksum;
        }

        public static Room Parse(string room)
        {
            var match = Regex.Match(room, "^(?<Letters>[\\D-]+)-(?<SectorId>\\d+)\\[(?<Checksum>\\w{5})\\]$");
            var letters = match.Groups["Letters"].Value;
            var sectorId = int.Parse(match.Groups["SectorId"].Value);
            var checksum = match.Groups["Checksum"].Value;

            return new Room(letters, sectorId, checksum);
        }

        public string GetDecryptedName()
        {
            var chars = EncryptedName.ToCharArray();
            var shifts = SectorId % 26;
            var decryptedName = "";

            foreach (var letter in EncryptedName)
            {
                if (letter == '-')
                {
                    decryptedName += " ";
                }
                else
                {
                    int alphabetIndex = letter - 'a';
                    int shiftedAlphabetIndex = (alphabetIndex + shifts) % 26;
                    char shiftedCharacter = (char)(shiftedAlphabetIndex + 'a');

                    decryptedName += shiftedCharacter;
                }
            }

            return decryptedName;
        }

        public bool IsReal()
        {
            var chars = EncryptedName.
                Replace("-", "").
                GroupBy(c => c).
                OrderByDescending(g => g.Count()).
                ThenBy(g => g.Key).
                Select(g => g.Key).
                Take(5).
                ToArray();

            var actualChecksum = new string(chars);
            var roomIsReal = actualChecksum == Checksum;

            return roomIsReal;
        }
    }
}
