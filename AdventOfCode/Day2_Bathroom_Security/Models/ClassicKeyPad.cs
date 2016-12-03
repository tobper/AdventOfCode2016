using System;

namespace AdventOfCode.Day2_Bathroom_Security.Models
{


    class ClassicKeyPad : IKeyPad
    {
        private int _number = 5;

        public char Key => (char)(_number + '0');

        public void Down()
        {
            if (Array.IndexOf(new[] { 1, 2, 3, 4, 5, 6 }, _number) != -1)
                _number += 3;
        }

        public void Left()
        {
            if (Array.IndexOf(new[] { 2, 3, 5, 6, 8, 9 }, _number) != -1)
                _number -= 1;
        }

        public void Right()
        {
            if (Array.IndexOf(new[] { 1, 2, 4, 5, 7, 8 }, _number) != -1)
                _number += 1;
        }

        public void Up()
        {
            if (Array.IndexOf(new[] { 4, 5, 6, 7, 8, 9 }, _number) != -1)
                _number -= 3;
        }
    }
}
