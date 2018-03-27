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

        [Test]
        public void TestLeft() {
            Robot robot = new Robot();
            robot.left();

            Assert.AreEqual(0, robot.X);
            Assert.AreEqual(0, robot.Y);
            Assert.AreEqual("WEST", robot.Facing);
        }

        [Test]
        public void TestLeftFromWEST() {
            Robot robot = new Robot(0, 0, "WEST");
            robot.left();

            Assert.AreEqual(0, robot.X);
            Assert.AreEqual(0, robot.Y);
            Assert.AreEqual("SOUTH", robot.Facing);
        }

        [Test]
        public void TestLeftFromSOUTH() {
            Robot robot = new Robot(0, 0, "SOUTH");
            robot.left();

            Assert.AreEqual(0, robot.X);
            Assert.AreEqual(0, robot.Y);
            Assert.AreEqual("EAST", robot.Facing);
        }

        [Test]
        public void TestLeftFromEAST() {
            Robot robot = new Robot(0, 0, "EAST");
            robot.left();

            Assert.AreEqual(0, robot.X);
            Assert.AreEqual(0, robot.Y);
            Assert.AreEqual("NORTH", robot.Facing);
        }

        [Test]
        public void TestRight() {
            Robot robot = new Robot();
            robot.right();

            Assert.AreEqual(0, robot.X);
            Assert.AreEqual(0, robot.Y);
            Assert.AreEqual("EAST", robot.Facing);
        }

        [Test]
        public void TestRightFromEAST() {
            Robot robot = new Robot(0, 0, "EAST");
            robot.right();

            Assert.AreEqual(0, robot.X);
            Assert.AreEqual(0, robot.Y);
            Assert.AreEqual("SOUTH", robot.Facing);
        }

        [Test]
        public void TestRightFromSOUTH() {
            Robot robot = new Robot(0, 0, "SOUTH");
            robot.right();

            Assert.AreEqual(0, robot.X);
            Assert.AreEqual(0, robot.Y);
            Assert.AreEqual("WEST", robot.Facing);
        }

        [Test]
        public void TestRightFromWEST() {
            Robot robot = new Robot(0, 0, "WEST");
            robot.right();

            Assert.AreEqual(0, robot.X);
            Assert.AreEqual(0, robot.Y);
            Assert.AreEqual("NORTH", robot.Facing);
        }

    }
}
