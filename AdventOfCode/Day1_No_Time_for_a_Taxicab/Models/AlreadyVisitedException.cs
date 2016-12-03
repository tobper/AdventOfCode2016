using System;

namespace AdventOfCode.Day1_No_Time_for_a_Taxicab.Models
{

    public class AlreadyVisitedException : Exception
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public AlreadyVisitedException(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}