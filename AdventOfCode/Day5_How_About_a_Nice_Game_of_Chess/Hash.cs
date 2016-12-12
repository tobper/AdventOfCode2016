using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AdventOfCode.Day5_How_About_a_Nice_Game_of_Chess
{
    class Hash
    {
        private static MD5 MD5 = MD5.Create();

        public bool IsValid { get; private set; }
        public string Value { get; private set; }

        public Hash(string doorId, uint index)
        {
            var buffer = Encoding.UTF8.GetBytes(doorId + index);
            var hash = MD5.ComputeHash(buffer);

            if (hash[0] == 0 && hash[1] == 0 && hash[2] < 0x10)
            {
                Value = String.Join(String.Empty, hash.Select(b => b.ToString("x2")));
                IsValid = true;
            }
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
