using System.Collections.Generic;
using System.Security.Cryptography;

namespace AdventOfCode.Day5_How_About_a_Nice_Game_of_Chess
{
    abstract class PasswordGenerator
    {
        private static MD5 MD5 = MD5.Create();

        public uint Index { get; protected set; }
        public string DoorId { get; private set; }

        public PasswordGenerator(string doorId)
        {
            DoorId = doorId;
        }

        protected IEnumerable<string> GetValidHashes()
        {
            while (true)
            {
                Index += 1;

                var hash = new Hash(DoorId, Index);
                if (hash.IsValid)
                    yield return hash.Value;
            };
        }
    }
}
