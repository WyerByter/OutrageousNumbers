using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutrageousNumbers;

namespace OutrageousNumbersTests.OutrageousInts
{
    [TestClass()]
    public class OperatorsTests
    {
        private const int V = 42;

        // test for + unary operator
        [TestMethod()]
        public void OutrageousIntUnaryPlusTest()
        {
            OutrageousInt oi = new(V);
            Assert.AreEqual(V, (+oi).Value, "OutrageousInt did not properly implement unary +");
        }

        // test for - unary operator
        [TestMethod()]
        public void OutrageousIntUnaryMinusTest()
        {
            OutrageousInt oi = new(V);
            Assert.AreEqual(-V, (-oi).Value, "OutrageousInt did not properly implement unary -");
        }

        // test for ++ prefix operator
        [TestMethod()]
        public void OutrageousIntIncrementTest()
        {
            OutrageousInt oi = new(V);
            Assert.AreEqual(V + 1, (++oi).Value, "OutrageousInt did not properly implement ++");
        }

        // test for checked ++ postfix operator
        [TestMethod()]
        public void OutrageousIntCheckedIncrementTest()
        {
            OutrageousInt oi = new(V);
            Assert.AreEqual(V + 1, checked(++oi).Value, "OutrageousInt did not properly implement checked ++");
        }

        // test for checked ++ postfix operator overflow
        [TestMethod()]
        public void OutrageousIntCheckedIncrementOverflowTest()
        {
            OutrageousInt oi = new(int.MaxValue);
            Assert.ThrowsException<OverflowException>(
                () => checked(++oi),
                "OutrageousInt did not properly implement checked ++ overflow");
        }

        // test for -- prefix operator
        [TestMethod()]
        public void OutrageousIntDecrementTest()
        {
            OutrageousInt oi = new(V);
            Assert.AreEqual(V - 1, (--oi).Value, "OutrageousInt did not properly implement --");
        }

        // test for -- postfix operator
        [TestMethod()]
        public void OutrageousIntCheckedDecrementTest()
        {
            OutrageousInt oi = new(V);
            Assert.AreEqual(V - 1, (--oi).Value, "OutrageousInt did not properly implement checked --");
        }

        // test for checked -- postfix operator overflow
        [TestMethod()]
        public void OutrageousIntCheckedDecrementOverflowTest()
        {
            OutrageousInt oi = new(int.MinValue);
            Assert.ThrowsException<OverflowException>(
                () => checked(--oi),
                "OutrageousInt did not properly implement checked -- overflow");
        }

        // test for + binary operator
        [TestMethod()]
        public void OutrageousIntAdditionTest()
        {
            OutrageousInt oi1 = new(V);
            OutrageousInt oi2 = new(V);
            Assert.AreEqual(V + V, (oi1 + oi2).Value, "OutrageousInt did not properly implement binary +");
        }

        // test for checked + binary operator
        [TestMethod()]
        public void OutrageousIntCheckedAdditionTest()
        {
            OutrageousInt oi1 = new(V);
            OutrageousInt oi2 = new(V);
            Assert.AreEqual(
                V + V,
                checked(oi1 + oi2).Value,
                "OutrageousInt did not properly implement checked binary +");
        }

        // test for checked + binary operator overflow
        [TestMethod()]
        public void OutrageousIntCheckedAdditionOverflowTest()
        {
            OutrageousInt oi1 = new(int.MaxValue);
            OutrageousInt oi2 = new(1);
            Assert.ThrowsException<OverflowException>(
                () => checked(oi1 + oi2),
                "OutrageousInt did not properly implement binary + overflow");
        }

        // test for - binary operator
        [TestMethod()]
        public void OutrageousIntSubtractionTest()
        {
            OutrageousInt oi1 = new(V);
            OutrageousInt oi2 = new(V);
            Assert.AreEqual(V - V, (oi1 - oi2).Value, "OutrageousInt did not properly implement binary -");
        }

        // test for checked - binary operator
        [TestMethod()]
        public void OutrageousIntCheckedSubtractionTest()
        {
            OutrageousInt oi1 = new(V);
            OutrageousInt oi2 = new(V);
            Assert.AreEqual(
                V - V,
                checked(oi1 - oi2).Value,
                "OutrageousInt did not properly implement checked binary -");
        }

        // test for checked - binary operator overflow
        [TestMethod()]
        public void OutrageousIntChecedSubtractionOverflowTest()
        {
            OutrageousInt oi1 = new(int.MinValue);
            OutrageousInt oi2 = new(1);
            Assert.ThrowsException<OverflowException>(
                () => checked(oi1 - oi2),
                "OutrageousInt did not properly implement binary - overflow");
        }

        // test for * binary operator
        [TestMethod()]
        public void OutrageousIntMultiplicationTest()
        {
            OutrageousInt oi1 = new(V);
            OutrageousInt oi2 = new(V);
            Assert.AreEqual(V * V, (oi1 * oi2).Value, "OutrageousInt did not properly implement binary *");
        }

        // test for checked * binary operator
        [TestMethod()]
        public void OutrageousIntCheckedMultiplicationTest()
        {
            OutrageousInt oi1 = new(V);
            OutrageousInt oi2 = new(V);
            Assert.AreEqual(
                V * V,
                checked(oi1 * oi2).Value,
                "OutrageousInt did not properly implement checked binary *");
        }

        // test for checked * binary operator overflow
        [TestMethod()]
        public void OutrageousIntCheckedMultiplicationOverflowTest()
        {
            OutrageousInt oi1 = new(int.MaxValue);
            OutrageousInt oi2 = new(2);
            Assert.ThrowsException<OverflowException>(
                () => checked(oi1 * oi2),
                "OutrageousInt did not properly implement binary * overflow");
        }

        // test for / binary operator
        [TestMethod()]
        public void OutrageousIntDivisionTest()
        {
            OutrageousInt oi1 = new(V);
            OutrageousInt oi2 = new(V);
            Assert.AreEqual(V / V, (oi1 / oi2).Value, "OutrageousInt did not properly implement binary /");
        }

        // test for checked / binary operator
        [TestMethod()]
        public void OutrageousIntCheckedDivisionTest()
        {
            OutrageousInt oi1 = new(V);
            OutrageousInt oi2 = new(V);
            Assert.AreEqual(
                V / V,
                checked(oi1 / oi2).Value,
                "OutrageousInt did not properly implement checked binary /");
        }

        // test for checked / binary operator divide by zero
        [TestMethod()]
        public void OutrageousIntCheckedDivisionByZeroTest()
        {
            OutrageousInt oi1 = new(V);
            OutrageousInt oi2 = new(0);
            Assert.ThrowsException<DivideByZeroException>(
                () => checked(oi1 / oi2),
                "OutrageousInt did not properly implement binary / divide by zero");
        }

        // test for % binary operator
        [TestMethod()]
        public void OutrageousIntModulusTest()
        {
            OutrageousInt oi1 = new(V);
            OutrageousInt oi2 = new(V);
            Assert.AreEqual(V % V, (oi1 % oi2).Value, "OutrageousInt did not properly implement binary %");
        }
    }
}
