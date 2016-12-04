using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day3_Squares_With_Three_Sides
{
    class Triangle
    {
        public Triangle(int[] sides)
        {
            Sides = sides.
                OrderBy(n => n).
                ToArray();
        }

        public bool IsValid => SmallerSides.Sum() > LargestSide;
        public int LargestSide => Sides.Last();
        public ICollection<int> Sides { get; private set; }
        public IEnumerable<int> SmallerSides => Sides.Take(Sides.Count - 1);
    }
}
