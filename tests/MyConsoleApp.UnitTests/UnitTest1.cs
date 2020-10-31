using NUnit.Framework;

namespace MyConsoleApp.UnitTests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.True(Greetings.Hello("world") == "Hello world!");
        }
    }
}