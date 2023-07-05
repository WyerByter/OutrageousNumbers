using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutrageousNumbers;

namespace OutrageousNumbersTests.OutrageousInts
{
    [TestClass()]
    public class ConstructorTests
    {
        private const int V = 42;

        [TestMethod()]
        public void OutrageousIntConstructorNoArgTest()
        {
            OutrageousInt oi = new();
            Assert.AreEqual(0, oi.Value, "OutrageousInt did not properly initialize");
        }

        [TestMethod()]
        public void OutrageousIntConstructorIntArgTest()
        {
            OutrageousInt oi = new(V);
            Assert.AreEqual(V, oi.Value, "OutrageousInt did not properly initialize");
        }

        [TestMethod()]
        public void OutrageousIntConstructorOutrageousIntTest()
        {
            OutrageousInt initial = new(V);
            OutrageousInt oi = new(initial);

            Assert.IsFalse(ReferenceEquals(initial, oi), "New OutrageousInt should be a copy");
            Assert.AreEqual(initial, oi, "OutrageousInt did not properly initialize");
        }
    }
}
