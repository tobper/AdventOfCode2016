using System.Collections.Generic;

namespace AdventOfCode
{
    public static class Extensions
    {
        public static TValue TryGetValue<TKey, TValue>(
            this IDictionary<TKey, TValue> dictionary,
            TKey key,
            TValue defaultValue = default(TValue))
        {
            return dictionary.TryGetValue(key, out var value)
                ? value
                : defaultValue;
        }
    }
}
