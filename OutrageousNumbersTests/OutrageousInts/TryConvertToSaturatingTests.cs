using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutrageousNumbers;

namespace OutrageousNumbersTests.OutrageousInts
{
    [TestClass()]
    public class TryConvertToSaturatingTests
    {
        [TestMethod()]
        public void TryConvertToSaturatingByteTrueTest()
        {
            byte expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToSaturating(oi, out byte b),
                "TryConvertToSaturating for byte should have returned true");
            Assert.AreEqual(expected, b, "TryConvertToSaturating for byte returned wrong value");
        }

        [TestMethod()]
        public void TryConvertToSaturatingByteTrueMaxTest()
        {
            var oi = new OutrageousInt(byte.MaxValue + 1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToSaturating(oi, out byte b),
                "TryConvertToSaturating for byte should have returned true");
            Assert.AreEqual(byte.MaxValue, b, "TryConvertToSaturating for byte returned wrong value");
        }

        [TestMethod()]
        public void TryConvertToSaturatingByteTrueMinTest()
        {
            var oi = new OutrageousInt(byte.MinValue - 1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToSaturating(oi, out byte b),
                "TryConvertToSaturating for byte should have returned true");
            Assert.AreEqual(byte.MinValue, b, "TryConvertToSaturating for byte returned wrong value");
        }

        [TestMethod()]
        public void TryConvertToSaturatingCharTrueTest()
        {
            var expected = (char)1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToSaturating(oi, out char c),
                "TryConvertToSaturating for char returned false");
            Assert.AreEqual(expected, c, "TryConvertToSaturating for char returned wrong value");
        }

        [TestMethod()]
        public void TryConvertToSaturatingCharTrueMaxTest()
        {
            var oi = new OutrageousInt(char.MaxValue + 1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToSaturating(oi, out char c),
                "TryConvertToSaturating for char should have returned true");
            Assert.AreEqual(char.MaxValue, c, "TryConvertToSaturating for char returned wrong value");
        }

        [TestMethod()]
        public void TryConvertToSaturatingCharTrueMinTest()
        {
            var oi = new OutrageousInt(char.MinValue - 1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToSaturating(oi, out char c),
                "TryConvertToSaturating for char should have returned true");
            Assert.AreEqual(char.MinValue, c, "TryConvertToSaturating for char returned wrong value");
        }

        [TestMethod()]
        public void TryConvertToSaturatingDecimalTrueTest()
        {
            decimal expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToSaturating(oi, out decimal d),
                "TryConvertToSaturating for decimal returned false");
            Assert.AreEqual(expected, d, "TryConvertToSaturating for decimal returned wrong value");
        }

        [TestMethod()]
        public void TryConvertToSaturatingUshortTrueTest()
        {
            ushort expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToSaturating(oi, out ushort us),
                "TryConvertToSaturating for ushort returned false");
            Assert.AreEqual(expected, us, "TryConvertToSaturating for ushort returned wrong value");
        }

        [TestMethod()]
        public void TryConvertToSaturatingUshortTrueMaxTest()
        {
            var oi = new OutrageousInt(ushort.MaxValue + 1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToSaturating(oi, out ushort us),
                "TryConvertToSaturating for ushort should have returned true");
            Assert.AreEqual(ushort.MaxValue, us, "TryConvertToSaturating for ushort returned wrong value");
        }

        [TestMethod()]
        public void TryConvertToSaturatingUshortTrueMinTest()
        {
            var oi = new OutrageousInt(ushort.MinValue - 1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToSaturating(oi, out ushort us),
                "TryConvertToSaturating for ushort should have returned true");
            Assert.AreEqual(ushort.MinValue, us, "TryConvertToSaturating for ushort returned wrong value");
        }

        // Test for uint
        [TestMethod()]
        public void TryConvertToSaturatingUintTrueTest()
        {
            uint expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToSaturating(oi, out uint ui),
                "TryConvertToSaturating for uint returned false");
            Assert.AreEqual(expected, ui, "TryConvertToSaturating for uint returned wrong value");
        }

        [TestMethod()]
        public void TryConvertToSaturatingUintTrueMinTest()
        {
            var oi = new OutrageousInt((int)uint.MinValue - 1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToSaturating(oi, out uint ui),
                "TryConvertToSaturating for uint should have returned true");
            Assert.AreEqual(uint.MinValue, ui, "TryConvertToSaturating for uint returned wrong value");
        }

        // Test for ulong
        [TestMethod()]
        public void TryConvertToSaturatingUlongTrueTest()
        {
            ulong expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToSaturating(oi, out ulong ul),
                "TryConvertToSaturating for ulong returned false");
            Assert.AreEqual(expected, ul, "TryConvertToSaturating for ulong returned wrong value");
        }

        // Test for ulong MinValue
        [TestMethod()]
        public void TryConvertToSaturatingUlongTrueMinTest()
        {
            var oi = new OutrageousInt((int)ulong.MinValue - 1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToSaturating(oi, out ulong ul),
                "TryConvertToSaturating for ulong should have returned true");
            Assert.AreEqual(ulong.MinValue, ul, "TryConvertToSaturating for ulong returned wrong value");
        }

        // Test for UInt128
        [TestMethod()]
        public void TryConvertToSaturatingUInt128TrueTest()
        {
            UInt128 expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToSaturating(oi, out UInt128 ui128),
                "TryConvertToSaturating for UInt128 returned false");
            Assert.AreEqual(expected, ui128, "TryConvertToSaturating for UInt128 returned wrong value");
        }

        // Test for UInt128 MinValue
        [TestMethod()]
        public void TryConvertToSaturatingUInt128TrueMinTest()
        {
            var oi = new OutrageousInt((int)UInt128.MinValue - 1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToSaturating(oi, out UInt128 ui128),
                "TryConvertToSaturating for UInt128 should have returned true");
            Assert.AreEqual(UInt128.MinValue, ui128, "TryConvertToSaturating for UInt128 returned wrong value");
        }

        // Test for nuint
        [TestMethod()]
        public void TryConvertToSaturatingNuintTrueTest()
        {
            nuint expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToSaturating(oi, out nuint nui),
                "TryConvertToSaturating for nuint returned false");
            Assert.AreEqual(expected, nui, "TryConvertToSaturating for nuint returned wrong value");
        }

        // Test for nuint MinValue
        [TestMethod()]
        public void TryConvertToSaturatingNuintTrueMinTest()
        {
            var oi = new OutrageousInt((int)nuint.MinValue - 1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToSaturating(oi, out nuint nui),
                "TryConvertToSaturating for nuint should have returned true");
            Assert.AreEqual(nuint.MinValue, nui, "TryConvertToSaturating for nuint returned wrong value");
        }
    }
}
