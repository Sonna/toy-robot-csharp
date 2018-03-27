using NUnit.Framework;
using System;
using System.IO;

using ToyRobot;

namespace ToyRobot.UnitTests
{
    public class ToyRobot_CLI
    {
        [SetUp]
        public void Setup()
        {
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
        public void TestProcessWithStreamWriter() {
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
        public void TestProcessWithExampleA() {
            TextWriter oldConsoleOut = Console.Out;
            StringWriter strWriter = new StringWriter();
            Console.SetOut(strWriter);

            // Console.SetIn(new StreamReader("../../../../examples/example_a.txt"));
            // CLI.process(Console.OpenStandardInput());
            string filename = "../../../../examples/example_a.txt";
            FileStream fileStream = new FileStream(
                filename, FileMode.Open, FileAccess.Read, FileShare.Read
            );
            CLI.process(fileStream);

            Assert.AreEqual("0,0,NORTH\n", strWriter.ToString());

            // cleanup
            Console.SetOut(oldConsoleOut);
            strWriter.Close();
        }

        [Test]
        public void TestProcessWithExampleB() {
            TextWriter oldConsoleOut = Console.Out;
            StringWriter strWriter = new StringWriter();
            Console.SetOut(strWriter);

            // Console.SetIn(new StreamReader("../../../../examples/example_b.txt"));
            // CLI.process(Console.OpenStandardInput());
            string filename = "../../../../examples/example_b.txt";
            FileStream fileStream = new FileStream(
                filename, FileMode.Open, FileAccess.Read, FileShare.Read
            );
            CLI.process(fileStream);

            Assert.AreEqual("0,0,WEST\n", strWriter.ToString());

            // cleanup
            Console.SetOut(oldConsoleOut);
            strWriter.Close();
        }

        [Test]
        public void TestProcessWithExampleC() {
            TextWriter oldConsoleOut = Console.Out;
            StringWriter strWriter = new StringWriter();
            Console.SetOut(strWriter);

            string filename = "../../../../examples/example_c.txt";
            FileStream fileStream = new FileStream(
                filename, FileMode.Open, FileAccess.Read, FileShare.Read
            );
            CLI.process(fileStream);

            Assert.AreEqual("3,3,NORTH\n", strWriter.ToString());

            // cleanup
            Console.SetOut(oldConsoleOut);
            strWriter.Close();
        }
    }
}
