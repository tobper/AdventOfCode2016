namespace AdventOfCode.Day1_No_Time_for_a_Taxicab.Models
{

    class Walker
    {
        private Point _location = new Point();
        public Direction Direction { get; private set; }
        public int X => _location.X;
        public int Y => _location.Y;

        public Walker()
        {
            Goto(0, 0);
        }

        public void TurnLeft()
        {
            switch (Direction)
            {
                case Direction.North: Direction = Direction.East; break;
                case Direction.East: Direction = Direction.South; break;
                case Direction.South: Direction = Direction.West; break;
                case Direction.West: Direction = Direction.North; break;
            }
        }

        public void TurnRight()
        {
            switch (Direction)
            {
                case Direction.North: Direction = Direction.West; break;
                case Direction.East: Direction = Direction.North; break;
                case Direction.South: Direction = Direction.East; break;
                case Direction.West: Direction = Direction.South; break;
            }
        }

        public void Walk(int steps)
        {
            var xModifier = 0;
            var yModifier = 0;

            switch (Direction)
            {
                case Direction.North: yModifier = 1; break;
                case Direction.East: xModifier = 1; break;
                case Direction.South: yModifier = -1; break;
                case Direction.West: xModifier = -1; break;
            }

            for (var i = 0; i < steps; i++)
            {
                Goto(X + xModifier, Y + yModifier);
            }
        }

        protected virtual void Goto(int x, int y)
        {
            _location.X = x;
            _location.Y = y;
        }
    }
}