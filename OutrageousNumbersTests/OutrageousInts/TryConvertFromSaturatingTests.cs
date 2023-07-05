using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutrageousNumbers;

namespace OutrageousNumbersTests.OutrageousInts
{
    [TestClass()]
    public class TryConvertFromSaturatingTests
    {
        [TestMethod()]
        public void TryConvertFromSaturatingDoubleTrueTest()
        {
            var expected = new OutrageousInt(1);
            var d = 1.0;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(d, out var oi),
                "TryConvertFromSaturating for double returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromSaturating for double returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromSaturatingDoubleTrueMaxTest()
        {
            var expected = new OutrageousInt(int.MaxValue);
            var d = double.MaxValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(d, out var oi),
                "TryConvertFromSaturating for double should have returned true");
            Assert.AreEqual(
                expected,
                oi,
                "TryConvertFromSaturating for double should have returned MaxValue");
        }

        [TestMethod()]
        public void TryConvertFromSaturatingDoubleTrueMinTest()
        {
            var expected = new OutrageousInt(int.MinValue);
            var d = double.MinValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(d, out var oi),
                "TryConvertFromSaturating for double should have returned true");
            Assert.AreEqual(
                expected,
                oi,
                "TryConvertFromSaturating for double should have returned MinValue");
        }

        [TestMethod()]
        public void TryConvertFromSaturatingHalfTrueTest()
        {
            var expected = new OutrageousInt(1);
            var h = (Half)1.0f;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(h, out var oi),
                "TryConvertFromSaturating for Half returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromSaturating for Half returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromSaturatingHalfTrueMaxTest()
        {
            var expected = new OutrageousInt(int.MaxValue);
            var h = (Half)float.MaxValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(h, out var oi),
                "TryConvertFromSaturating for Half should have returned true");
            Assert.AreEqual(
                expected,
                oi,
                "TryConvertFromSaturating for Half should have returned MaxValue");
        }

        [TestMethod()]
        public void TryConvertFromSaturatingHalfTrueMinTest()
        {
            var expected = new OutrageousInt(int.MinValue);
            var h = (Half)float.MinValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(h, out var oi),
                "TryConvertFromSaturating for Half should have returned true");
            Assert.AreEqual(
                expected,
                oi,
                "TryConvertFromSaturating for Half should have returned MinValue");
        }

        [TestMethod()]
        public void TryConvertFromSaturatingShortTrueTest()
        {
            var expected = new OutrageousInt(1);
            short s = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(s, out var oi),
                "TryConvertFromSaturating for short returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromSaturating for short returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromSaturatingIntTrueTest()
        {
            var expected = new OutrageousInt(1);
            var i = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(i, out var oi),
                "TryConvertFromSaturating for int returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromSaturating for int returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromSaturatingLongTrueTest()
        {
            var expected = new OutrageousInt(1);
            long l = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(l, out var oi),
                "TryConvertFromSaturating for long returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromSaturating for long returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromSaturatingLongTrueMaxTest()
        {
            var expected = new OutrageousInt(int.MaxValue);
            var l = long.MaxValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(l, out var oi),
                "TryConvertFromSaturating for long should have returned true");
            Assert.AreEqual(
                expected,
                oi,
                "TryConvertFromSaturating for long should have returned MaxValue");
        }

        [TestMethod()]
        public void TryConvertFromSaturatingLongTrueMinTest()
        {
            var expected = new OutrageousInt(int.MinValue);
            var l = long.MinValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(l, out var oi),
                "TryConvertFromSaturating for long should have returned true");
            Assert.AreEqual(
                expected,
                oi,
                "TryConvertFromSaturating for long should have returned MinValue");
        }

        [TestMethod()]
        public void TryConvertFromSaturatingInt128TrueTest()
        {
            var expected = new OutrageousInt(1);
            Int128 i = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(i, out var oi),
                "TryConvertFromSaturating for Int128 returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromSaturating for Int128 returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromSaturatingInt128TrueMaxTest()
        {
            var expected = new OutrageousInt(int.MaxValue);
            var i = Int128.MaxValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(i, out var oi),
                "TryConvertFromSaturating for Int128 should have returned true");
            Assert.AreEqual(
                expected,
                oi,
                "TryConvertFromSaturating for Int128 should have returned MaxValue");
        }

        [TestMethod()]
        public void TryConvertFromSaturatingInt128TrueMinTest()
        {
            var expected = new OutrageousInt(int.MinValue);
            var i = Int128.MinValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(i, out var oi),
                "TryConvertFromSaturating for Int128 should have returned true");
            Assert.AreEqual(
                expected,
                oi,
                "TryConvertFromSaturating for Int128 should have returned MinValue");
        }

        [TestMethod()]
        public void TryConvertFromSaturatingNintTrueTest()
        {
            var expected = new OutrageousInt(1);
            nint n = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(n, out var oi),
                "TryConvertFromSaturating for nint returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromSaturating for nint returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromSaturatingNintTrueMaxTest()
        {
            var expected = new OutrageousInt(int.MaxValue);
            var n = nint.MaxValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(n, out var oi),
                "TryConvertFromSaturating for nint should have returned true");
            Assert.AreEqual(
                expected,
                oi,
                "TryConvertFromSaturating for nint should have returned MaxValue");

        }

        [TestMethod()]
        public void TryConvertFromSaturatingNintTrueMinTest()
        {
            var expected = new OutrageousInt(int.MinValue);
            var n = nint.MinValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(n, out var oi),
                "TryConvertFromSaturating for nint should have returned true");
            Assert.AreEqual(
                expected,
                oi,
                "TryConvertFromSaturating for nint should have returned MinValue");
        }

        [TestMethod()]
        public void TryConvertFromSaturationgSbyteTrueTest()
        {
            var expected = new OutrageousInt(1);
            sbyte sb = 1;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(sb, out var oi),
                "TryConvertFromSaturating for sbyte returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromSaturating for sbyte returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromSaturatingFloatTrueTest()
        {
            var expected = new OutrageousInt(1);
            var f = 1.0f;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(f, out var oi),
                "TryConvertFromSaturating for float returned true");
            Assert.AreEqual(expected, oi, "TryConvertFromSaturating for float returned wrong value");
        }

        [TestMethod()]
        public void TryConvertFromSaturatingFloatTrueMaxTest()
        {
            var expected = new OutrageousInt(int.MaxValue);
            var f = float.MaxValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(f, out var oi),
                "TryConvertFromSaturating for float should have returned true");
            Assert.AreEqual(
                expected,
                oi,
                "TryConvertFromSaturating for float should have returned MaxValue");
        }

        [TestMethod()]
        public void TryConvertFromSaturatingFloatTrueMinTest()
        {
            var expected = new OutrageousInt(int.MinValue);
            var f = float.MinValue;
            Assert.IsTrue(
                OutrageousInt.TryConvertFromSaturating(f, out var oi),
                "TryConvertFromSaturating for float should have returned true");
            Assert.AreEqual(
                expected,
                oi,
                "TryConvertFromSaturating for float should have returned MinValue");
        }
    }
}
