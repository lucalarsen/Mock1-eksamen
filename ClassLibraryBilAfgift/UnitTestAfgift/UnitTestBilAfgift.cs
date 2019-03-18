using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryBilAfgift;

namespace UnitTestAfgift
{
    [TestClass]
    public class UnitTestBilAfgift
    {
        [TestMethod]
        public void BilAfgiftlav()
        {
            Afgift afgift1 = new Afgift();

            decimal pris = afgift1.BilAfgift(200000);

            Assert.AreEqual(170000, pris);
        }

        [TestMethod]
        public void BilAfgiftHøj()
        {
            Afgift afgift1 = new Afgift();

            decimal pris = afgift1.BilAfgift(300000);

            Assert.AreEqual(320000, pris);
        }

        [TestMethod]
        public void ElBilAfgiftLav()
        {
            Afgift afgift1 = new Afgift();

            decimal pris = afgift1.ElbilAfgift(200000);

            Assert.AreEqual(34000, pris);
        }

        [TestMethod]
        public void ElBilAfgiftHøj()
        {
            Afgift afgift1 = new Afgift();

            decimal pris = afgift1.ElbilAfgift(300000);

            Assert.AreEqual(64000, pris);
        }
    }
}
