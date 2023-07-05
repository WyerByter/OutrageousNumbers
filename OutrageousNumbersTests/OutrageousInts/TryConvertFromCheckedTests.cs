using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutrageousNumbers;

namespace OutrageousNumbersTests.OutrageousInts
{
    [TestClass()]
    public class TryConvertFromCheckedTests
    {
        [TestMethod()]
        public void TryConvertFromCheckedDoubleSucceedTest()
        {
            var expected = new OutrageousInt(1);
            var d = 1.0;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromChecked(d, out var oi),
                "TryConvertFromChecked for double returned false");
            Assert.AreEqual(expected, oi, "TryConvertFromChecked for double returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromCheckedDoubleFailTest()
        {
            var d = double.MaxValue;
            Assert.ThrowsException<OverflowException>(
                () => OutrageousInt.TryConvertFromChecked(d, out var oi),
                "TryConvertFromChecked for double should have thrown an exception");
        }

        [TestMethod()]
        public void TryConvertFromCheckedHalfSucceedTest()
        {
            var expected = new OutrageousInt(1);
            var h = (Half)1.0f;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromChecked(h, out var oi),
                "TryConvertFromChecked for Half returned false");
            Assert.AreEqual(expected, oi, "TryConvertFromChecked for Half returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromCheckedHalfFailTest()
        {
            var h = (Half)double.MaxValue;
            Assert.ThrowsException<OverflowException>(
                () => OutrageousInt.TryConvertFromChecked(h, out var oi),
                "TryConvertFromChecked for Half should have thrown an exception");
        }

        [TestMethod()]
        public void TryConvertFromCheckedShortSucceedTest()
        {
            var expected = new OutrageousInt(1);
            short s = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromChecked(s, out var oi),
                "TryConvertFromChecked for short returned false");
            Assert.AreEqual(expected, oi, "TryConvertFromChecked for short returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromCheckedIntSucceedTest()
        {
            var expected = new OutrageousInt(1);
            var i = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromChecked(i, out var oi),
                "TryConvertFromChecked for int returned false");
            Assert.AreEqual(expected, oi, "TryConvertFromChecked for int returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromCheckedLongSucceedTest()
        {
            var expected = new OutrageousInt(1);
            long l = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromChecked(l, out var oi),
                "TryConvertFromChecked for long returned false");
            Assert.AreEqual(expected, oi, "TryConvertFromChecked for long returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromCheckedLongFailTest()
        {
            var l = long.MaxValue;
            Assert.ThrowsException<OverflowException>(
                () => OutrageousInt.TryConvertFromChecked(l, out var oi),
                "TryConvertFromChecked for long should have thrown an exception");
        }

        [TestMethod()]
        public void TryConvertFromCheckedInt128SucceedTest()
        {
            var expected = new OutrageousInt(1);
            Int128 i128 = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromChecked(i128, out var oi),
                "TryConvertFromChecked for Int128 returned false");
            Assert.AreEqual(expected, oi, "TryConvertFromChecked for Int128 returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromCheckedInt128FailTest()
        {
            var int128 = Int128.MaxValue;
            Assert.ThrowsException<OverflowException>(
                () => OutrageousInt.TryConvertFromChecked(int128, out var oi),
                "TryConvertFromChecked for Int128 should have thrown an exception");
        }

        [TestMethod()]
        public void TryConvertFromCheckedNintSucceedTest()
        {
            var expected = new OutrageousInt(1);
            nint nint = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromChecked(nint, out var oi),
                "TryConvertFromChecked for nint returned false");
            Assert.AreEqual(expected, oi, "TryConvertFromChecked for nint returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromCheckedNintFailTest()
        {
            var nInt = nint.MaxValue;
            Assert.ThrowsException<OverflowException>(
                () => OutrageousInt.TryConvertFromChecked(nInt, out var oi),
                "TryConvertFromChecked for nint should have thrown an exception");
        }

        [TestMethod()]
        public void TryConvertFromCheckedSByteSucceedTest()
        {
            var expected = new OutrageousInt(1);
            sbyte sb = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromChecked(sb, out var oi),
                "TryConvertFromChecked for sbyte returned false");
            Assert.AreEqual(expected, oi, "TryConvertFromChecked for sbyte returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromCheckedFloatSucceedTest()
        {
            var expected = new OutrageousInt(1);
            var f = 1.0f;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromChecked(f, out var oi),
                "TryConvertFromChecked for float returned false");
            Assert.AreEqual(expected, oi, "TryConvertFromChecked for float returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromCheckedFloatFailTest()
        {
            var f = float.MaxValue;
            Assert.ThrowsException<OverflowException>(
                () => OutrageousInt.TryConvertFromChecked(f, out var oi),
                "TryConvertFromChecked for float should have thrown an exception");
        }
    }
}
