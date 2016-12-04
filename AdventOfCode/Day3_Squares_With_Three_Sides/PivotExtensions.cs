using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Day3_Squares_With_Three_Sides
{

    public static class PivotExtensions
    {
        public static IEnumerable<int[]> Pivot(this int[][] matrix, int numberOfColumns = 3)
        {
            for (int i = 0; i < matrix.Length; i += numberOfColumns)
            {
                for (int column = 0; column < numberOfColumns; column++)
                {
                    yield return matrix.
                        Skip(i).
                        Take(numberOfColumns).
                        Select(numbers => numbers[column]).
                        ToArray();
                }
            }
        }
    }
}
