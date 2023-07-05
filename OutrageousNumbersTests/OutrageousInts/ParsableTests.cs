using Microsoft.VisualStudio.TestTools.UnitTesting;
using OutrageousNumbers;
using System.Globalization;

namespace OutrageousNumbersTests.OutrageousInts
{
    [TestClass()]
    public class ParsableTests
    {
        private const int V = 42;

        // test for Parse for span
        [TestMethod()]
        public void ParseSpanTest()
        {
            OutrageousInt expected = new(V);
            var span = V.ToString().AsSpan();
            Assert.AreEqual(
                expected,
                OutrageousInt.Parse(span, null),
                "Parse for span returned wrong value");
        }

        // test for Parse for span with IFormatProvider
        [TestMethod()]
        public void ParseSpanIFormatProviderTest()
        {
            OutrageousInt expected = new(V);
            var span = V.ToString().AsSpan();
            IFormatProvider provider = CultureInfo.InvariantCulture;
            Assert.AreEqual(
                expected,
                OutrageousInt.Parse(span, provider),
                "Parse for span returned wrong value");
        }

        // test for Parse for span with NuberStyles
        [TestMethod()]
        public void ParseSpanNumberStylesTest()
        {
            OutrageousInt expected = new(V);
            var span = V.ToString().AsSpan();
            var style = NumberStyles.Integer;
            Assert.AreEqual(
                expected,
                OutrageousInt.Parse(span, style, null),
                "Parse for span returned wrong value");
        }

        // test for Parse for span with NumberStyles and IFormatProvider
        [TestMethod()]
        public void ParseSpanNumberStylesAndIFormatProviderTest()
        {
            OutrageousInt expected = new(V);
            var span = V.ToString().AsSpan();
            var style = NumberStyles.Integer;
            IFormatProvider provider = CultureInfo.InvariantCulture;
            Assert.AreEqual(
                expected,
                OutrageousInt.Parse(span, style, provider),
                "Parse for span returned wrong value");
        }

        // test for Parse for span with invalid span
        [TestMethod()]
        public void ParseSpanInvalidSpanTest()
        {
            var s = "abc";
            Assert.ThrowsException<FormatException>(
                () => OutrageousInt.Parse(s.AsSpan(), null),
                "Parse for span did not throw FormatException");
        }

        // test of Parse for string
        [TestMethod()]
        public void ParseStringTest()
        {
            OutrageousInt expected = new(V);
            var s = V.ToString();
            Assert.AreEqual(
                expected,
                OutrageousInt.Parse(s, null),
                "Parse for string returned wrong value");
        }

        // test for Parse for string with IFormatProvider
        [TestMethod()]
        public void ParseStringIFormatProviderTest()
        {
            OutrageousInt expected = new(V);
            var s = V.ToString();
            IFormatProvider provider = CultureInfo.InvariantCulture;
            Assert.AreEqual(
                expected,
                OutrageousInt.Parse(s, provider),
                "Parse for string returned wrong value");
        }

        // test for Parse for string with NumberStyles
        [TestMethod()]
        public void ParseStringNumberStylesTest()
        {
            OutrageousInt expected = new(V);
            var s = V.ToString();
            var style = NumberStyles.Integer;
            Assert.AreEqual(
                expected,
                OutrageousInt.Parse(s, style, null),
                "Parse for string returned wrong value");
        }

        // test for Parse for string with NumberStyles and IFormatProvider
        [TestMethod()]
        public void ParseStringNumberStylesIFormatProviderTest()
        {
            OutrageousInt expected = new(V);
            var s = V.ToString();
            var style = NumberStyles.Integer;
            IFormatProvider provider = CultureInfo.InvariantCulture;
            Assert.AreEqual(
                expected,
                OutrageousInt.Parse(s, style, provider),
                "Parse for string returned wrong value");
        }

        // test for Parse for string with invalid string
        [TestMethod()]
        public void ParseStringInvalidStringTest()
        {
            var s = "abc";
            Assert.ThrowsException<FormatException>(
                () => OutrageousInt.Parse(s, null),
                "Parse for string did not throw FormatException");
        }

        // test for TryParse for span
        [TestMethod()]
        public void TryParseSpanTest()
        {
            OutrageousInt expected = new(V);
            var span = V.ToString().AsSpan();

            Assert.IsTrue(
                OutrageousInt.TryParse(span, null, out var oi),
                "TryParse for span returned false");
            Assert.AreEqual(expected, oi, "TryParse for span returned wrong value");
        }

        // test for TryParse for span with IFormatProvider
        [TestMethod()]
        public void TryParseSpanIFormatProviderTest()
        {
            OutrageousInt expected = new(V);
            var span = V.ToString().AsSpan();
            IFormatProvider provider = CultureInfo.InvariantCulture;

            Assert.IsTrue(
                OutrageousInt.TryParse(span, provider, out var oi),
                "TryParse for span returned false");
            Assert.AreEqual(expected, oi, "TryParse for span returned wrong value");
        }

        // test for TryParse for span with NumberStyles
        [TestMethod()]
        public void TryParseSpanNumberStylesTest()
        {
            OutrageousInt expected = new(V);
            var span = V.ToString().AsSpan();
            var style = NumberStyles.Integer;

            Assert.IsTrue(
                OutrageousInt.TryParse(span, style, null, out var oi),
                "TryParse for span returned false");
            Assert.AreEqual(expected, oi, "TryParse for span returned wrong value");
        }

        // test for TryParse for span with NumberStyles and IFormatProvider
        [TestMethod()]
        public void TryParseSpanNumberStylesAndIFormatProviderTest()
        {
            OutrageousInt expected = new(V);
            var span = V.ToString().AsSpan();
            var style = NumberStyles.Integer;
            IFormatProvider provider = CultureInfo.InvariantCulture;

            Assert.IsTrue(
                OutrageousInt.TryParse(span, style, provider, out var oi),
                "TryParse for span returned false");
            Assert.AreEqual(expected, oi, "TryParse for span returned wrong value");
        }

        // test for TryParse for span with invalid span
        [TestMethod()]
        public void TryParseSpanInvalidSpanTest()
        {
            var s = "abc";
            Assert.IsFalse(
                OutrageousInt.TryParse(s.AsSpan(), null, out _),
                "TryParse for span returned true");
        }

        // test for TryParse for string
        [TestMethod()]
        public void TryParseStringTest()
        {
            OutrageousInt expected = new(V);
            var s = V.ToString();
            var style = NumberStyles.Integer;
            IFormatProvider provider = CultureInfo.InvariantCulture;

            Assert.IsTrue(
                OutrageousInt.TryParse(s, style, provider, out var oi),
                "TryParse for string returned false");
            Assert.AreEqual(expected, oi, "TryParse for string returned wrong value");
        }

        // test for TryParse for string with IFormatProvider
        [TestMethod()]
        public void TryParseStringIFormatProviderTest()
        {
            OutrageousInt expected = new(V);
            var s = V.ToString();
            IFormatProvider provider = CultureInfo.InvariantCulture;

            Assert.IsTrue(
                OutrageousInt.TryParse(s, provider, out var oi),
                "TryParse for string returned false");
            Assert.AreEqual(expected, oi, "TryParse for string returned wrong value");
        }

        // test for TryParse for string with NumberStyles
        [TestMethod()]
        public void TryParseStringNumberStylesTest()
        {
            OutrageousInt expected = new(V);
            var s = V.ToString();
            var style = NumberStyles.Integer;

            Assert.IsTrue(
                OutrageousInt.TryParse(s, style, null, out var oi),
                "TryParse for string returned false");
            Assert.AreEqual(expected, oi, "TryParse for string returned wrong value");
        }

        // test for TryParse for string with NumberStyles and IFormatProvider
        [TestMethod()]
        public void TryParseStringNumberStylesIFormatProviderTest()
        {
            OutrageousInt expected = new(V);
            var s = V.ToString();
            var style = NumberStyles.Integer;
            IFormatProvider provider = CultureInfo.InvariantCulture;

            Assert.IsTrue(
                OutrageousInt.TryParse(s, style, provider, out var oi),
                "TryParse for string returned false");
            Assert.AreEqual(expected, oi, "TryParse for string returned wrong value");
        }

        // test for TryParse for string with invalid string
        [TestMethod()]
        public void TryParseStringInvalidStringTest()
        {
            var s = "abc";
            Assert.IsFalse(
                OutrageousInt.TryParse(s, null, out _),
                "TryParse for string returned true");
        }
    }
}
