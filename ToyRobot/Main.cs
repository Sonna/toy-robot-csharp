// A Hello World! program in C#.
using System;
using ToyRobot;

namespace HelloWorld
{
    class Hello
    {
        static void Main()
        {
            Robot robot = new Robot();
            Console.WriteLine("Hello World!");

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
