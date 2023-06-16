using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OutrageousNumbers
{
    public partial class OutrageousInt
    {
        public static OutrageousInt One => new(1);

        public static int Radix => 10;

        public static OutrageousInt Zero => new(0);

        public static OutrageousInt Abs(OutrageousInt value) => new(Math.Abs(value.Value));

        public static bool IsCanonical(OutrageousInt value) => true;

        public static bool IsComplexNumber(OutrageousInt value) => false;

        public static bool IsEvenInteger(OutrageousInt value) => value.Value % 2 == 0;

        public static bool IsFinite(OutrageousInt value) => !IsNaN(value);

        public static bool IsImaginaryNumber(OutrageousInt value) => false;

        public static bool IsInfinity(OutrageousInt value) => false;

        public static bool IsInteger(OutrageousInt value) => true;

        public static bool IsNaN(OutrageousInt value) => false;

        public static bool IsNegative(OutrageousInt value) => value.Value < 0;

        public static bool IsNegativeInfinity(OutrageousInt value) => false;

        public static bool IsNormal(OutrageousInt value) => true;

        public static bool IsOddInteger(OutrageousInt value) => value.Value % 2 == 1;

        public static bool IsPositive(OutrageousInt value) => value.Value > 0;

        public static bool IsPositiveInfinity(OutrageousInt value) => false;

        public static bool IsRealNumber(OutrageousInt value) => true;

        public static bool IsSubnormal(OutrageousInt value) => false;

        public static bool IsZero(OutrageousInt value) => value.Value == 0;

        public static OutrageousInt MaxMagnitude(OutrageousInt x, OutrageousInt y) => x.Value >= y.Value ? x : y;

        public static OutrageousInt MaxMagnitudeNumber(OutrageousInt x, OutrageousInt y) => x.Value >= y.Value ? x : y;

        public static OutrageousInt MinMagnitude(OutrageousInt x, OutrageousInt y) => x.Value <= y.Value ? x : y;

        public static OutrageousInt MinMagnitudeNumber(OutrageousInt x, OutrageousInt y) => x.Value <= y.Value ? x : y;

        public static OutrageousInt Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider) => new(OutrageousInt.Parse(s, style, provider));

        public static OutrageousInt Parse(string s, NumberStyles style, IFormatProvider? provider) => new(OutrageousInt.Parse(s, style, provider));

        public static bool TryConvertFromChecked<TOther>(TOther value, out OutrageousInt result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromSaturating<TOther>(TOther value, out OutrageousInt result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromTruncating<TOther>(TOther value, out OutrageousInt result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToChecked<TOther>(OutrageousInt value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToSaturating<TOther>(OutrageousInt value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToTruncating<TOther>(OutrageousInt value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out OutrageousInt result)
        {
            var success = int.TryParse(s, style, provider, out int value);
            result = success ? new OutrageousInt(value) : null;
            return success;
        }

        public static bool TryParse([NotNullWhen(true)] string? s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out OutrageousInt result)
        {
            var success = int.TryParse(s, style, provider, out int value);
            result = success ? new OutrageousInt(value) : null;
            return success;
        }
    }
}
