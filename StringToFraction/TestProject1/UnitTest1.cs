using NUnit.Framework;
using StringToFraction;

namespace TestProject1
{
    public class Tests
    {
        [Test]
        public void smile67KataTest_withoutRandom1()
        {
            Assert.AreEqual("3/4", new Kata().toFraction(0.75));
        }
        [Test]
        public void smile67KataTest_withoutRandom2()
        {
            Assert.AreEqual("-1/3", new Kata().toFraction(-0.333333333333333));
        }
        [Test]
        public void smile67KataTest_withoutRandom3()
        {
            Assert.AreEqual("3", new Kata().toFraction(3));
        }
        [Test]
        public void smile67KataTest_withoutRandom4()
        {
            Assert.AreEqual("5/6", new Kata().toFraction(0.833333333333333));
        }
        [Test]
        public void smile67KataTest_withoutRandom5()
        {
            Assert.AreEqual("0", new Kata().toFraction(0));
        }
    }
}