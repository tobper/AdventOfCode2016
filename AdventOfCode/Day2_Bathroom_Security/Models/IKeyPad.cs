namespace AdventOfCode.Day2_Bathroom_Security.Models
{
    interface IKeyPad
    {
        char Key { get; }

        void Down();
        void Left();
        void Right();
        void Up();
    }
}
