using System.Threading;
using NUnit.Framework;

namespace Class.test
{
    [TestFixture]
    public class Class1Test
    {
        [Test]
        public void A()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(true);
        }

        [Test]
        public void B()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(true);
        }
        [Test]
        public void C()
        {
            Thread.Sleep(1000);
            Assert.IsTrue(true);
        }
    }
}
