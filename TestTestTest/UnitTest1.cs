using FluentAssertions;
using TestTest;

namespace TestTestTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var temp = new Class1();
            temp.Add(4, 5).Should().Be(9);
        }
    }
}