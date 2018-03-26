using NUnit.Framework;
using System;
using System.IO;

using ToyRobot;

namespace ToyRobot.UnitTests
{
    public class ToyRobot_Robot
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestConstructor()
        {
            Robot robot = new Robot();

            Assert.AreEqual(0, robot.X);
            Assert.AreEqual(0, robot.Y);
            Assert.AreEqual("NORTH", robot.Facing);
        }

        [Test]
        public void TestStringWriterCaptureConsoleOutput() {
            TextWriter oldConsoleOut = Console.Out;
            StringWriter strWriter = new StringWriter();

            Console.SetOut(strWriter);
            Console.WriteLine("Hello World");
            Console.SetOut(oldConsoleOut);

            // strWriter.Write("Hello World");
            Assert.AreEqual("Hello World\n", strWriter.ToString());
            strWriter.Close();
        }

        [Test]
        public void TestReport() {
            TextWriter oldConsoleOut = Console.Out;
            StringWriter strWriter = new StringWriter();
            Console.SetOut(strWriter);

            Robot robot = new Robot();
            robot.report();

            Assert.AreEqual("0,0,NORTH\n", strWriter.ToString());

            // cleanup
            Console.SetOut(oldConsoleOut);
            strWriter.Close();
        }
    }
}
