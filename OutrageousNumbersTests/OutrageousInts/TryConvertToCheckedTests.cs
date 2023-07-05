using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutrageousNumbers;

namespace OutrageousNumbersTests.OutrageousInts
{
    [TestClass()]
    public class TryConvertToCheckedTests
    {
        [TestMethod()]
        public void TryConvertToCheckedByteTrueTest()
        {
            byte expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToChecked(oi, out byte b),
                "TryConvertToChecked for byte returned false");
            Assert.AreEqual(expected, b, "TryConvertToChecked for byte returned wrong value");
        }

        [TestMethod()]
        public void TryConvertToCheckedByteFalseMaxTest()
        {
            var oi = new OutrageousInt(byte.MaxValue + 1);
            Assert.ThrowsException<OverflowException>(
                () => OutrageousInt.TryConvertToChecked(oi, out byte b),
                "TryConvertFromChecked for byte should have thrown an exception");
        }

        [TestMethod()]
        public void TryConvertToCheckedByteFalseMinTest()
        {
            var oi = new OutrageousInt(byte.MinValue - 1);
            Assert.ThrowsException<OverflowException>(
                () => OutrageousInt.TryConvertToChecked(oi, out byte b),
                "TryConvertFromChecked for byte should have thrown an exception");
        }

        [TestMethod()]
        public void TryConvertToCheckedCharTrueTest()
        {
            var expected = (char)1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToChecked(oi, out char c),
                "TryConvertToChecked for char returned false");
            Assert.AreEqual(expected, c, "TryConvertToChecked for char returned wrong value");
        }

        [TestMethod()]
        public void TryConvertToCheckedCharFalseMaxTest()
        {
            var oi = new OutrageousInt(char.MaxValue + 1);
            Assert.ThrowsException<OverflowException>(
                () => OutrageousInt.TryConvertToChecked(oi, out char c),
                "TryConvertFromChecked for char should have thrown an exception");
        }

        [TestMethod()]
        public void TryConvertToCheckedCharFalseMinTest()
        {
            var oi = new OutrageousInt(char.MinValue - 1);
            Assert.ThrowsException<OverflowException>(
                () => OutrageousInt.TryConvertToChecked(oi, out char c),
                "TryConvertFromChecked for char should have thrown an exception");
        }

        [TestMethod()]
        public void TryConvertToCheckedDecimalTrueTest()
        {
            decimal expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToChecked(oi, out decimal d),
                "TryConvertToChecked for decimal returned false");
            Assert.AreEqual(expected, d, "TryConvertToChecked for decimal returned wrong value");
        }

        [TestMethod()]
        public void TryConvertToCheckedUshortTrueTest()
        {
            ushort expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToChecked(oi, out ushort us),
                "TryConvertToChecked for ushort returned false");
            Assert.AreEqual(expected, us, "TryConvertToChecked for ushort returned wrong value");
        }

        [TestMethod()]
        public void TryConvertToCheckedUshortFalseMaxTest()
        {
            var oi = new OutrageousInt(ushort.MaxValue + 1);
            Assert.ThrowsException<OverflowException>(
                () => OutrageousInt.TryConvertToChecked(oi, out ushort us),
                "TryConvertFromChecked for ushort should have thrown an exception");
        }

        [TestMethod()]
        public void TryConvertToCheckedUshortFalseMinTest()
        {
            var oi = new OutrageousInt(ushort.MinValue - 1);
            Assert.ThrowsException<OverflowException>(
                () => OutrageousInt.TryConvertToChecked(oi, out ushort us),
                "TryConvertFromChecked for ushort should have thrown an exception");
        }

        [TestMethod()]
        public void TryConvertToCheckedUintTrueTest()
        {
            uint expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToChecked(oi, out uint ui),
                "TryConvertToChecked for uint returned false");
            Assert.AreEqual(expected, ui, "TryConvertToChecked for uint returned wrong value");
        }

        [TestMethod()]
        public void TryConvertToCheckedULongTrueTest()
        {
            ulong expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToChecked(oi, out ulong ul),
                "TryConvertToChecked for ulong returned false");
            Assert.AreEqual(expected, ul, "TryConvertToChecked for ulong returned wrong value");
        }

        [TestMethod()]
        public void TryConvertToCheckedUInt128TrueTest()
        {
            UInt128 expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToChecked(oi, out UInt128 ui128),
                "TryConvertToChecked for UInt128 returned false");
            Assert.AreEqual(expected, ui128, "TryConvertToChecked for UInt128 returned wrong value");
        }

        [TestMethod()]
        public void TryConvertToCheckedNuintTrueTest()
        {
            nuint expected = 1;
            var oi = new OutrageousInt(1);
            Assert.IsTrue(
                OutrageousInt.TryConvertToChecked(oi, out nuint nui),
                "TryConvertToChecked for nuint returned false");
            Assert.AreEqual(expected, nui, "TryConvertToChecked for nuint returned wrong value");
        }
    }
}
