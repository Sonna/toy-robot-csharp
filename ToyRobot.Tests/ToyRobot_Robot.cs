using NUnit.Framework;
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
    }
}
