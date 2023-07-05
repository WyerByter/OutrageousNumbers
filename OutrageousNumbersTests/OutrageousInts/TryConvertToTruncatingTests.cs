using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutrageousNumbers;

namespace OutrageousNumbersTests.OutrageousInts
{
    [TestClass()]
    public class TryConvertToTruncatingTests
    {
        // test for byte
        [TestMethod()]
        public void TryConvertToTruncatingByteTrueTest()
        {
            byte expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToTruncating(oi, out byte b),
                "TryConvertToTruncating for byte should have returned true");
            Assert.AreEqual(expected, b, "TryConvertToTruncating for byte returned wrong value");
        }

        // test for byte MaxValue
        [TestMethod()]
        public void TryConvertToTruncatingByteTrueMaxTest()
        {
            var oi = new OutrageousInt(byte.MaxValue + 1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToTruncating(oi, out byte b),
                "TryConvertToTruncating for byte should have returned true");
            Assert.AreEqual(0, b, "TryConvertToTruncating for byte returned wrong value");
        }

        // test for byte MinValue
        [TestMethod()]
        public void TryConvertToTruncatingByteTrueMinTest()
        {
            var oi = new OutrageousInt(byte.MinValue - 1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToTruncating(oi, out byte b),
                "TryConvertToTruncating for byte should have returned true");
            Assert.AreEqual(byte.MaxValue, b, "TryConvertToTruncating for byte returned wrong value");
        }

        // test for char
        [TestMethod()]
        public void TryConvertToTruncatingCharTrueTest()
        {
            var expected = (char)1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToTruncating(oi, out char c),
                "TryConvertToTruncating for char returned false");
            Assert.AreEqual(expected, c, "TryConvertToTruncating for char returned wrong value");
        }

        // test for char MaxValue
        [TestMethod()]
        public void TryConvertToTruncatingCharTrueMaxTest()
        {
            var oi = new OutrageousInt(char.MaxValue + 1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToTruncating(oi, out char c),
                "TryConvertToTruncating for char should have returned true");
            Assert.AreEqual((char)0, c, "TryConvertToTruncating for char returned wrong value");
        }

        // test for char MinValue
        [TestMethod()]
        public void TryConvertToTruncatingCharTrueMinTest()
        {
            var oi = new OutrageousInt(char.MinValue - 1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToTruncating(oi, out char c),
                "TryConvertToTruncating for char should have returned true");
            Assert.AreEqual(char.MaxValue, c, "TryConvertToTruncating for char returned wrong value");
        }

        // test for decimal
        [TestMethod()]
        public void TryConvertToTruncatingDecimalTrueTest()
        {
            decimal expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToTruncating(oi, out decimal d),
                "TryConvertToTruncating for decimal returned false");
            Assert.AreEqual(expected, d, "TryConvertToTruncating for decimal returned wrong value");
        }

        // test for ushort
        [TestMethod()]
        public void TryConvertToTruncatingUShortTrueTest()
        {
            ushort expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToTruncating(oi, out ushort us),
                "TryConvertToTruncating for ushort returned false");
            Assert.AreEqual(expected, us, "TryConvertToTruncating for ushort returned wrong value");
        }

        // test for ushort MaxValue
        [TestMethod()]
        public void TryConvertToTruncatingUShortTrueMaxTest()
        {
            var oi = new OutrageousInt(ushort.MaxValue + 1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToTruncating(oi, out ushort us),
                "TryConvertToTruncating for ushort should have returned true");
            Assert.AreEqual((ushort)0, us, "TryConvertToTruncating for ushort returned wrong value");
        }

        // test for ushort MinValue
        [TestMethod()]
        public void TryConvertToTruncatingUShortTrueMinTest()
        {
            var oi = new OutrageousInt(ushort.MinValue - 1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToTruncating(oi, out ushort us),
                "TryConvertToTruncating for ushort should have returned true");
            Assert.AreEqual(ushort.MaxValue, us, "TryConvertToTruncating for ushort returned wrong value");
        }

        // test for uint
        [TestMethod()]
        public void TryConvertToTruncatingUIntTrueTest()
        {
            uint expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToTruncating(oi, out uint ui),
                "TryConvertToTruncating for uint returned false");
            Assert.AreEqual(expected, ui, "TryConvertToTruncating for uint returned wrong value");
        }

        // test for ulong
        [TestMethod()]
        public void TryConvertToTruncatingULongTrueTest()
        {
            ulong expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToTruncating(oi, out ulong ul),
                "TryConvertToTruncating for ulong returned false");
            Assert.AreEqual(expected, ul, "TryConvertToTruncating for ulong returned wrong value");
        }

        // test for UInt128
        [TestMethod()]
        public void TryConvertToTruncatingUInt128TrueTest()
        {
            UInt128 expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToTruncating(oi, out UInt128 ui128),
                "TryConvertToTruncating for UInt128 returned false");
            Assert.AreEqual(expected, ui128, "TryConvertToTruncating for UInt128 returned wrong value");
        }

        // test for nuint
        [TestMethod()]
        public void TryConvertToTruncatingNUIntTrueTest()
        {
            nuint expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToTruncating(oi, out nuint nui),
                "TryConvertToTruncating for nuint returned false");
            Assert.AreEqual(expected, nui, "TryConvertToTruncating for nuint returned wrong value");
        }
    }
}
