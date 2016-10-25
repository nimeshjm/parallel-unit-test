using System.Threading;
using NUnit.Framework;

namespace Class.test
{
    [TestFixture]
    public class Class2Test
    {
        [Test]
        public void D()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(true);
        }

        [Test]
        public void E()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(true);
        }
        [Test]
        public void F()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(true);
        }
    }
}