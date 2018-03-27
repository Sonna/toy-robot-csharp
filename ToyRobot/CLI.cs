// A Hello World! program in C#.
using System;
using System.IO;

namespace ToyRobot
{
    public static class CLI
    {
        public static void process(Stream input) {
            Robot robot = new Robot();

            using (StreamReader reader = new StreamReader(input)) {
                string line;
                string command = "";
                string commandArgs = "";

                while ((line = reader.ReadLine()) != null && line != "EXIT") {
                    string[] parts = line.Split(' ');

                    if (parts.Length > 0) {
                        command = parts[0];

                        if (parts.Length > 1) {
                            commandArgs = parts[1];
                        }
                    }

                    robot.exec(command, commandArgs);

                    command = "";
                    commandArgs = "";
                }
            }
        }

        public static void main(string[] args) {
            if (args.Length > 0) {
                // File
                string filename = args[0];
                FileStream fileStream = new FileStream(
                    filename, FileMode.Open, FileAccess.Read, FileShare.Read
                );

                process(fileStream);

                fileStream.Close();
            }
            else {
                // Console.In
                process(Console.OpenStandardInput());
            }
        }
    }
}
