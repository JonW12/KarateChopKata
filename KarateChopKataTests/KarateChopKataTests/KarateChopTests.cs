using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KarateChopKataTests
{
    [TestClass]
    public class KarateChopTests
    {
        KarateChopKata.BinarySearch bs = new KarateChopKata.BinarySearch();

        [TestMethod]
        public void TestEmptyArray()
        {
            Assert.AreEqual(-1, bs.Chop(3, new int[] { }));
        }

        [TestMethod]
        public void TestNotInArray()
        {
            Assert.AreEqual(-1, bs.Chop(3, new int[] { 1 }));
        }

        [TestMethod]
        public void TestInArray()
        {
            Assert.AreEqual(0, bs.Chop(1, new int[] { 1 }));
        }

        [TestMethod]
        public void AdditionalTestsFromKata()
        {
            int[] testarr = new int[3] { 1, 3, 5 };

            Assert.AreEqual(0, bs.Chop(1, testarr));
            Assert.AreEqual(1, bs.Chop(3, testarr));
            Assert.AreEqual(2, bs.Chop(5, testarr));
            Assert.AreEqual(-1, bs.Chop(0, testarr));
            Assert.AreEqual(-1, bs.Chop(2, testarr));
            Assert.AreEqual(-1, bs.Chop(4, testarr));
            Assert.AreEqual(-1, bs.Chop(6, testarr));
        }
    }
}
