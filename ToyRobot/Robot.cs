// A Hello World! program in C#.
using System;

namespace ToyRobot
{
    public class Robot
    {
        private int x;
        private int y;
        private string facing;

        public int X { get; set; }
        // {
        //     get { return x; }
        //     set { x = value; }
        // }
        public int Y { get; set; }
        // {
        //     get { return y; }
        //     set { y = value; }
        // }
        public string Facing //{ get; set; }
        {
            get { return facing; }
            set { facing = value; }
        }

        public Robot(int x = 0, int y = 0, string facing = "NORTH") {
           this.x = x;
           this.y = y;
           this.facing = facing;
        }

        public report() {
           Console.WriteLine("{0},{1},{2}", X, Y, Facing);
        }
    }
}
