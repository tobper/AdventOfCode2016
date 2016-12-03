using System.Collections.Generic;

namespace AdventOfCode.Day1_No_Time_for_a_Taxicab.Models
{

    class LoggedWalker : Walker
    {
        private HashSet<string> _visitedLocations = new HashSet<string>();

        protected override void Goto(int x, int y)
        {
            base.Goto(x, y);

            var location = $"{x}.{y}";

            if (_visitedLocations.Contains(location))
                throw new AlreadyVisitedException(x, y);

            _visitedLocations.Add(location);
        }
    }
}