using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace OutrageousNumbers
{
    public class OutrageousInt : INumber<OutrageousInt>
    {
        public static OutrageousInt One => throw new NotImplementedException();

        public static int Radix => throw new NotImplementedException();

        public static OutrageousInt Zero => throw new NotImplementedException();

        public static OutrageousInt AdditiveIdentity => throw new NotImplementedException();

        public static OutrageousInt MultiplicativeIdentity => throw new NotImplementedException();

        private int Value { get; set; }

        public static OutrageousInt Abs(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static bool IsCanonical(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static bool IsComplexNumber(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static bool IsEvenInteger(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static bool IsFinite(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static bool IsImaginaryNumber(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static bool IsInfinity(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static bool IsInteger(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNaN(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNegative(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNegativeInfinity(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static bool IsNormal(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static bool IsOddInteger(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static bool IsPositive(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static bool IsPositiveInfinity(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static bool IsRealNumber(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static bool IsSubnormal(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static bool IsZero(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static OutrageousInt MaxMagnitude(OutrageousInt x, OutrageousInt y)
        {
            throw new NotImplementedException();
        }

        public static OutrageousInt MaxMagnitudeNumber(OutrageousInt x, OutrageousInt y)
        {
            throw new NotImplementedException();
        }

        public static OutrageousInt MinMagnitude(OutrageousInt x, OutrageousInt y)
        {
            throw new NotImplementedException();
        }

        public static OutrageousInt MinMagnitudeNumber(OutrageousInt x, OutrageousInt y)
        {
            throw new NotImplementedException();
        }

        public static OutrageousInt Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static OutrageousInt Parse(string s, NumberStyles style, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static OutrageousInt Parse(ReadOnlySpan<char> s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static OutrageousInt Parse(string s, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out OutrageousInt result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, NumberStyles style, IFormatProvider? provider, [MaybeNullWhen(false)] out OutrageousInt result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out OutrageousInt result)
        {
            throw new NotImplementedException();
        }

        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out OutrageousInt result)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(OutrageousInt? other)
        {
            throw new NotImplementedException();
        }

        public bool Equals(OutrageousInt? other)
        {
            throw new NotImplementedException();
        }

        public string ToString(string? format, IFormatProvider? formatProvider)
        {
            throw new NotImplementedException();
        }

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider)
        {
            throw new NotImplementedException();
        }

        public static OutrageousInt operator +(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static OutrageousInt operator +(OutrageousInt left, OutrageousInt right)
        {
            throw new NotImplementedException();
        }

        public static OutrageousInt operator -(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static OutrageousInt operator -(OutrageousInt left, OutrageousInt right)
        {
            throw new NotImplementedException();
        }

        public static OutrageousInt operator ++(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static OutrageousInt operator --(OutrageousInt value)
        {
            throw new NotImplementedException();
        }

        public static OutrageousInt operator *(OutrageousInt left, OutrageousInt right)
        {
            throw new NotImplementedException();
        }

        public static OutrageousInt operator /(OutrageousInt left, OutrageousInt right)
        {
            throw new NotImplementedException();
        }

        public static OutrageousInt operator %(OutrageousInt left, OutrageousInt right)
        {
            throw new NotImplementedException();
        }

        public static bool operator ==(OutrageousInt? left, OutrageousInt? right)
        {
            throw new NotImplementedException();
        }

        public static bool operator !=(OutrageousInt? left, OutrageousInt? right)
        {
            throw new NotImplementedException();
        }

        public static bool operator <(OutrageousInt left, OutrageousInt right)
        {
            throw new NotImplementedException();
        }

        public static bool operator >(OutrageousInt left, OutrageousInt right)
        {
            throw new NotImplementedException();
        }

        public static bool operator <=(OutrageousInt left, OutrageousInt right)
        {
            throw new NotImplementedException();
        }

        public static bool operator >=(OutrageousInt left, OutrageousInt right)
        {
            throw new NotImplementedException();
        }
    }
}