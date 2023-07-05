using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutrageousNumbers;

namespace OutrageousNumbersTests.OutrageousInts
{
    [TestClass()]
    public class TryConvertFromTruncatingTests
    {
        [TestMethod()]
        public void TryConvertFromTruncatingDoubleTrueTest()
        {
            var expected = new OutrageousInt(1);
            var d = 1.0;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(d, out var oi),
                "TryConvertFromTruncating for double should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for double returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingDoubleTrueMaxTest()
        {
            var expected = new OutrageousInt(int.MaxValue);
            var d = double.MaxValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(d, out var oi),
                "TryConvertFromTruncating for double should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for double returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingDoubleTrueMinTest()
        {
            var expected = new OutrageousInt(int.MinValue);
            var d = double.MinValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(d, out var oi),
                "TryConvertFromTruncating for double should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for double returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingHalfTrueTest()
        {
            var expected = new OutrageousInt(1);
            var h = (Half)1.0f;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(h, out var oi),
                "TryConvertFromTruncating for Half should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for Half returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingHalfTrueMaxTest()
        {
            var expected = new OutrageousInt(int.MaxValue);
            var h = (Half)double.MaxValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(h, out var oi),
                "TryConvertFromTruncating for Half should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for Half returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingHalfTrueMinTest()
        {
            var expected = new OutrageousInt(int.MinValue);
            var h = (Half)double.MinValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(h, out var oi),
                "TryConvertFromTruncating for Half should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for Half returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingShortTrueTest()
        {
            var expected = new OutrageousInt(1);
            short s = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(s, out var oi),
                "TryConvertFromTruncating for short should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for short returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingIntTrueTest()
        {
            var expected = new OutrageousInt(1);
            var i = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(i, out var oi),
                "TryConvertFromTruncating for int should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for int returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingLongTrueTest()
        {
            var expected = new OutrageousInt(1);
            long l = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(l, out var oi),
                "TryConvertFromTruncating for long should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for long returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingLongTrueMaxTest()
        {
            var expected = new OutrageousInt(-1);
            var l = long.MaxValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(l, out var oi),
                "TryConvertFromTruncating for long should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for long returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingLongTrueMinTest()
        {
            var expected = new OutrageousInt(0);
            var l = long.MinValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(l, out var oi),
                "TryConvertFromTruncating for long should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for long returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingInt128TrueTest()
        {
            var expected = new OutrageousInt(1);
            Int128 i128 = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(i128, out var oi),
                "TryConvertFromTruncating for Int128 should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for Int128 returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingInt128TrueMaxTest()
        {
            var expected = new OutrageousInt(-1);
            var i128 = Int128.MaxValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(i128, out var oi),
                "TryConvertFromTruncating for Int128 should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for Int128 returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingInt128TrueMinTest()
        {
            var expected = new OutrageousInt(0);
            var i128 = Int128.MinValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(i128, out var oi),
                "TryConvertFromTruncating for Int128 should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for Int128 returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingNintTrueTest()
        {
            var expected = new OutrageousInt(1);
            nint n = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(n, out var oi),
                "TryConvertFromTruncating for nint should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for nint returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingNintTrueMaxTest()
        {
            var expected = new OutrageousInt(-1);
            var n = nint.MaxValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(n, out var oi),
                "TryConvertFromTruncating for nint should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for nint returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingNintTrueMinTest()
        {
            var expected = new OutrageousInt(0);
            var n = nint.MinValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(n, out var oi),
                "TryConvertFromTruncating for nint should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for nint returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingSbyteTrueTest()
        {
            var expected = new OutrageousInt(1);
            sbyte sb = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(sb, out var oi),
                "TryConvertFromTruncating for sbyte should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for sbyte returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingFloatTrueTest()
        {
            var expected = new OutrageousInt(1);
            float f = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(f, out var oi),
                "TryConvertFromTruncating for float should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for float returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingFloatTrueMaxTest()
        {
            var expected = new OutrageousInt(int.MaxValue);
            var f = float.MaxValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(f, out var oi),
                "TryConvertFromTruncating for float should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for float returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromTruncatingFloatTrueMinTest()
        {
            var expected = new OutrageousInt(int.MinValue);
            var f = float.MinValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromTruncating(f, out var oi),
                "TryConvertFromTruncating for float should have returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromTruncating for float returned wrong value");
        }
    }
}
