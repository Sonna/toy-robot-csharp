// A Hello World! program in C#.
using System;
using System.Collections.Generic;

namespace ToyRobot
{
    public class Robot
    {
        //const
        readonly Dictionary<string, Dictionary<string, string>> TURN =
          new Dictionary<string, Dictionary<string, string>>
        {
            { "NORTH", new Dictionary<string, string> {
                    { "LEFT", "WEST" }, { "RIGHT", "EAST" }
                }
            },
            { "EAST", new Dictionary<string, string> {
                    { "LEFT", "NORTH" }, { "RIGHT", "SOUTH" }
                }
            },
            { "SOUTH", new Dictionary<string, string> {
                    { "LEFT", "EAST" }, { "RIGHT", "WEST" }
                }
            },
            { "WEST", new Dictionary<string, string> {
                    { "LEFT", "SOUTH" }, { "RIGHT", "NORTH" }
                }
            }
        };


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

        public void report() {
           Console.WriteLine("{0},{1},{2}", X, Y, Facing);
        }

        public void left() {
           this.facing = TURN[facing]["LEFT"];
        }
    }
}
