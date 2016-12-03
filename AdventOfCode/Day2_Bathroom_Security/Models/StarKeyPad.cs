namespace AdventOfCode.Day2_Bathroom_Security.Models
{

    class StarKeyPad : IKeyPad
    {
        public char Key { get; private set; } = '5';

        public void Down()
        {
            switch (Key)
            {
                case '1': Key = '3'; break;
                case '2': Key = '6'; break;
                case '3': Key = '7'; break;
                case '4': Key = '8'; break;
                case '6': Key = 'A'; break;
                case '7': Key = 'B'; break;
                case '8': Key = 'C'; break;
                case 'B': Key = 'D'; break;
            }
        }

        public void Left()
        {
            switch (Key)
            {
                case '3': Key = '2'; break;
                case '4': Key = '3'; break;
                case '6': Key = '5'; break;
                case '7': Key = '6'; break;
                case '8': Key = '7'; break;
                case '9': Key = '8'; break;
                case 'B': Key = 'A'; break;
                case 'C': Key = 'B'; break;
            }
        }

        public void Right()
        {
            switch (Key)
            {
                case '2': Key = '3'; break;
                case '3': Key = '4'; break;
                case '5': Key = '6'; break;
                case '6': Key = '7'; break;
                case '7': Key = '8'; break;
                case '8': Key = '9'; break;
                case 'A': Key = 'B'; break;
                case 'B': Key = 'C'; break;
            }
        }

        public void Up()
        {
            switch (Key)
            {
                case '3': Key = '1'; break;
                case '6': Key = '2'; break;
                case '7': Key = '3'; break;
                case '8': Key = '4'; break;
                case 'A': Key = '6'; break;
                case 'B': Key = '7'; break;
                case 'C': Key = '8'; break;
                case 'D': Key = 'B'; break;
            }
        }
    }
}
