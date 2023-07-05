using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutrageousNumbers;

namespace OutrageousNumbersTests.OutrageousInts
{
    [TestClass()]
    public class NumberBaseTests
    {
        private const int V = 42;

        // Test for One property
        [TestMethod()]
        public void OneTest()
        {
            OutrageousInt oi = OutrageousInt.One;
            Assert.AreEqual(1, oi.Value, "One property did not return 1");
        }

        // Test for Zero property
        [TestMethod()]
        public void ZeroTest()
        {
            OutrageousInt oi = OutrageousInt.Zero;
            Assert.AreEqual(0, oi.Value, "Zero property did not return 0");
        }

        // Test for Radix property
        [TestMethod()]
        public void RadixTest()
        {
            Assert.AreEqual(10, OutrageousInt.Radix, "Radix property did not return 10");
        }

        [TestMethod()]
        public void AbsTest()
        {
            OutrageousInt oi = new(-V);
            OutrageousInt expected = new(V);

            var abs = OutrageousInt.Abs(oi);
            Assert.AreEqual(expected, abs, "Absolute Value incorrect");
        }

        [TestMethod()]
        public void IsCanonicalTest()
        {
            OutrageousInt oi = new(V);
            Assert.IsTrue(OutrageousInt.IsCanonical(oi), "IsCanonical should always be true");
        }

        [TestMethod()]
        public void IsComplexNumberTest()
        {
            OutrageousInt oi = new(V);
            Assert.IsFalse(OutrageousInt.IsComplexNumber(oi), "IsComplexNumber should always be false");
        }

        [TestMethod()]
        public void IsEvenIntegerTrueTest()
        {
            OutrageousInt oi = new(V);
            Assert.IsTrue(OutrageousInt.IsEvenInteger(oi), "The OutrageousInt should be even");
        }

        [TestMethod()]
        public void IsEvenIntegerFalseTest()
        {
            OutrageousInt oi = new(V - 1);
            Assert.IsFalse(OutrageousInt.IsEvenInteger(oi), "The OutrageousInt should not be even");
        }

        [TestMethod()]
        public void IsFiniteTest()
        {
            OutrageousInt oi = new(V);
            Assert.IsTrue(OutrageousInt.IsFinite(oi), "IsFinite should always be true");
        }

        [TestMethod()]
        public void IsImaginaryNumberTest()
        {
            OutrageousInt oi = new(V);
            Assert.IsFalse(OutrageousInt.IsComplexNumber(oi), "IsComplexNumber should always be false");
        }

        [TestMethod()]
        public void IsInfinityTest()
        {
            OutrageousInt oi = new(V);
            Assert.IsFalse(OutrageousInt.IsInfinity(oi), "IsInfinity should always be false");
        }

        [TestMethod()]
        public void IsIntegerTest()
        {
            OutrageousInt oi = new(V);
            Assert.IsTrue(OutrageousInt.IsInteger(oi), "IsInteger should always be true");
        }

        [TestMethod()]
        public void IsNaNTest()
        {
            OutrageousInt oi = new(V);
            Assert.IsFalse(OutrageousInt.IsNaN(oi), "IsNaN should always be false");
        }

        [TestMethod()]
        public void IsNegativeTrueTest()
        {
            OutrageousInt oi = new(-V);
            Assert.IsTrue(OutrageousInt.IsNegative(oi), "IsNegative should have returned true");
        }

        [TestMethod()]
        public void IsNegativeFalseTest()
        {
            OutrageousInt oi = new(V);
            Assert.IsFalse(OutrageousInt.IsNegative(oi), "IsNegative should have returned false");
        }

        [TestMethod()]
        public void IsNegativeInfinityTest()
        {
            OutrageousInt oi = new(V);
            Assert.IsFalse(
                OutrageousInt.IsNegativeInfinity(oi),
                "IsNegativeInfinity should always be false");
        }

        [TestMethod()]
        public void IsNormalTest()
        {
            OutrageousInt oi = new(V);
            Assert.IsTrue(OutrageousInt.IsNormal(oi), "IsNormal should always be true");
        }

        [TestMethod()]
        public void IsOddIntegerTrueTest()
        {
            OutrageousInt oi = new(V - 1);
            Assert.IsTrue(OutrageousInt.IsOddInteger(oi), "The OutrageousInt should be odd");
        }

        [TestMethod()]
        public void IsOddIntegerFalseTest()
        {
            OutrageousInt oi = new(V);
            Assert.IsFalse(OutrageousInt.IsOddInteger(oi), "The OutrageousInt should not be odd");
        }

        [TestMethod()]
        public void IsPositiveTrueTest()
        {
            OutrageousInt oi = new(V);
            Assert.IsTrue(OutrageousInt.IsPositive(oi), "The OutrageousInt should be positive");
        }

        [TestMethod()]
        public void IsPositiveFalseTest()
        {
            OutrageousInt oi = new(-V);
            Assert.IsFalse(OutrageousInt.IsPositive(oi), "The OutrageousInt should not be positive");
        }

        [TestMethod()]
        public void IsPositiveInfinityTest()
        {
            OutrageousInt oi = new(V);
            Assert.IsFalse(
                OutrageousInt.IsPositiveInfinity(oi),
                "IsPositiveInfinity should always be false");
        }

        [TestMethod()]
        public void IsRealNumberTest()
        {
            OutrageousInt oi = new(V);
            Assert.IsTrue(OutrageousInt.IsRealNumber(oi), "IsRealNumber should always be true");
        }

        [TestMethod()]
        public void IsSubnormalTest()
        {
            OutrageousInt oi = new(V);
            Assert.IsFalse(OutrageousInt.IsSubnormal(oi), "IsSubnormal should always be false");
        }

        [TestMethod()]
        public void IsZeroTrueTest()
        {
            OutrageousInt oi = new(0);
            Assert.IsTrue(OutrageousInt.IsZero(oi), "IsZero should have returned true");
        }

        [TestMethod()]
        public void IsZeroFalseTest()
        {
            OutrageousInt oi = new(V);
            Assert.IsFalse(OutrageousInt.IsZero(oi), "IsZero should have returned true");
        }

        [TestMethod()]
        public void MaxMagnitudeLargePositiveTest()
        {
            OutrageousInt oi = new(-V);
            OutrageousInt oi2 = new(V + 1);
            Assert.AreEqual(
                oi2,
                OutrageousInt.MaxMagnitude(oi, oi2),
                "MaxMagnitude returned wrong value");
        }

        [TestMethod()]
        public void MaxMagnitudeLargeNegativeTest()
        {
            OutrageousInt oi = new(V);
            OutrageousInt oi2 = new(-(V + 1));
            Assert.AreEqual(
                oi2,
                OutrageousInt.MaxMagnitude(oi, oi2),
                "MaxMagnitude returned wrong value");
        }

        [TestMethod()]
        public void MaxMagnitudeNumberLargePositiveTest()
        {
            OutrageousInt oi = new(-V);
            OutrageousInt oi2 = new(V + 1);
            Assert.AreEqual(
                oi2,
                OutrageousInt.MaxMagnitudeNumber(oi, oi2),
                "MaxMagnitudeNumber returned wrong value");
        }

        [TestMethod()]
        public void MaxMagnitudeNumberLargeNegativeTest()
        {
            OutrageousInt oi = new(V);
            OutrageousInt oi2 = new(-(V + 1));
            Assert.AreEqual(
                oi2,
                OutrageousInt.MaxMagnitudeNumber(oi, oi2),
                "MaxMagnitudeNumber returned wrong value");
        }

        [TestMethod()]
        public void MinMagnitudeSmallPositiveTest()
        {
            OutrageousInt oi = new(V);
            OutrageousInt oi2 = new(-(V + 1));
            Assert.AreEqual(
                oi,
                OutrageousInt.MinMagnitude(oi, oi2),
                "MinMagnitude returned wrong value");
        }

        [TestMethod()]
        public void MinMagnitudeSmallNegativeTest()
        {
            OutrageousInt oi = new(-V);
            OutrageousInt oi2 = new(V + 1);
            Assert.AreEqual(
                oi,
                OutrageousInt.MinMagnitude(oi, oi2),
                "MinMagnitude returned wrong value");
        }

        [TestMethod()]
        public void MinMagnitudeNumberSmallPositiveTest()
        {
            OutrageousInt oi = new(V);
            OutrageousInt oi2 = new(-(V + 1));
            Assert.AreEqual(
                oi,
                OutrageousInt.MinMagnitudeNumber(oi, oi2),
                "MinMagnitudeNumber returned wrong value");
        }

        [TestMethod()]
        public void MinMagnitudeNumberSmallNegativeTest()
        {
            OutrageousInt oi = new(-V);
            OutrageousInt oi2 = new(V + 1);
            Assert.AreEqual(
                oi,
                OutrageousInt.MinMagnitudeNumber(oi, oi2),
                "MinMagnitudeNumber returned wrong value");
        }
    }
}
