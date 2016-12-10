using System.Linq;

namespace AdventOfCode.Day3_Squares_With_Three_Sides
{
    public class Day3
    {
        public static int Part1(string[] input)
        {
            var validTriagles =
                from numbers in input.ParseNumbers()
                let triangle = new Triangle(numbers)
                where triangle.IsValid
                select triangle;

            return validTriagles.Count();
        }

        public static int Part2(string[] input)
        {
            var validTriagles =
                from numbers in input.ParseNumbers().Pivot()
                let triangle = new Triangle(numbers)
                where triangle.IsValid
                select triangle;

            return validTriagles.Count();
        }
    }
}
