using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day6_Signals_and_Noise
{
    public class LetterCounter
    {
        private List<Dictionary<char, uint>> _letters = new List<Dictionary<char, uint>>();

        public void AddLetter(int position, char letter)
        {
            while (_letters.Count <= position)
            {
                _letters.Add(new Dictionary<char, uint>());
            }

            var dictionary = _letters[position];
            var count = dictionary.TryGetValue(letter) + 1;

            dictionary[letter] = count;
        }

        public char[] GetLeastCommonLetters()
        {
            return _letters.
                Select(letters =>
                {
                    return letters.
                        ToArray().
                        OrderBy(keyValue => keyValue.Value).
                        Select(keyValue => keyValue.Key).
                        First();
                }).
                ToArray();
        }

        public char[] GetMostCommonLetters()
        {
            return _letters.
                Select(letters =>
                {
                    return letters.
                        ToArray().
                        OrderByDescending(keyValue => keyValue.Value).
                        Select(keyValue => keyValue.Key).
                        First();
                }).
                ToArray();
        }
    }
}
