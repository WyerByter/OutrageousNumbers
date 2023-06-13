using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;

namespace OutrageousNumbers
{
    public class OutrageousInt : INumber<OutrageousInt>
    {
        public OutrageousInt() => Value = 0;

        public OutrageousInt(int value) => Value = value;

        public OutrageousInt(OutrageousInt value) => Value = value.Value;

        public static OutrageousInt One => new(1);

        public static int Radix => 10;

        public static OutrageousInt Zero => new(0);

        public static OutrageousInt AdditiveIdentity => Zero;

        public static OutrageousInt MultiplicativeIdentity => One;

        private int Value { get; set; }

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

        public static OutrageousInt Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider? provider) => new(int.Parse(s, style, provider));

        public static OutrageousInt Parse(string s, NumberStyles style, IFormatProvider? provider) => new(int.Parse(s, style, provider));

        public static OutrageousInt Parse(ReadOnlySpan<char> s, IFormatProvider? provider) => new(int.Parse(s, provider));

        public static OutrageousInt Parse(string s, IFormatProvider? provider) => new(int.Parse(s, provider));

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

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider? provider, [MaybeNullWhen(false)] out OutrageousInt result)
        {
            var success = int.TryParse(s, provider, out int value);
            result = success ? new OutrageousInt(value) : null;
            return success;
        }

        public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out OutrageousInt result)
        {
            var success = int.TryParse(s, provider, out int value);
            result = success ? new OutrageousInt(value) : null;
            return success;
        }

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

        public int CompareTo(object? obj) => obj is OutrageousInt other
                ? CompareTo(other)
                : throw new ArgumentException("Object must be of type OutrageousInt", nameof(obj));

        public int CompareTo(OutrageousInt? other) => other is null ? 1 : Value.CompareTo(other.Value);

        public bool Equals(OutrageousInt? other) => other is not null && Value.Equals(other.Value);

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider? provider) => Value.TryFormat(destination, out charsWritten, format, provider);

        public static OutrageousInt operator +(OutrageousInt value) => new(value);

        public static OutrageousInt operator +(OutrageousInt left, OutrageousInt right) => new(left.Value + right.Value);

        public static OutrageousInt operator -(OutrageousInt value) => new(value.Value * -1);

        public static OutrageousInt operator -(OutrageousInt left, OutrageousInt right) => new(left.Value - right.Value);

        public static OutrageousInt operator ++(OutrageousInt value) => value.Value == int.MaxValue
                ? throw new OverflowException("Cannot increment OutrageousInt above int.MaxValue")
                : new(value.Value + 1);

        public static OutrageousInt operator --(OutrageousInt value) => value.Value == int.MinValue
                ? throw new OverflowException("Cannot decrement OutrageousInt below int.MinValue")
                : new(value.Value - 1);

        public static OutrageousInt operator *(OutrageousInt left, OutrageousInt right) => new(left.Value * right.Value);

        public static OutrageousInt operator /(OutrageousInt left, OutrageousInt right) => new(left.Value / right.Value);

        public static OutrageousInt operator %(OutrageousInt left, OutrageousInt right) => new(left.Value % right.Value);

        public static bool operator ==(OutrageousInt? left, OutrageousInt? right) => left?.Equals(right) ?? right is null;

        public static bool operator !=(OutrageousInt? left, OutrageousInt? right) => !(left == right);

        public static bool operator <(OutrageousInt left, OutrageousInt right) => left.CompareTo(right) < 0;

        public static bool operator >(OutrageousInt left, OutrageousInt right) => left.CompareTo(right) > 0;

        public static bool operator <=(OutrageousInt left, OutrageousInt right) => left.CompareTo(right) <= 0;

        public static bool operator >=(OutrageousInt left, OutrageousInt right) => left.CompareTo(right) >= 0;

        public override bool Equals(object? obj) => obj is OutrageousInt other && Equals(other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}