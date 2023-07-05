using System.Numerics;

namespace OutrageousNumbers
{
    public partial class OutrageousInt
    {
        public static OutrageousInt One => new(1);

        public static int Radix => 10;

        public static OutrageousInt Zero => new(0);

        public static OutrageousInt Abs(OutrageousInt value) => new(int.Abs(value.Value));

        public static bool IsCanonical(OutrageousInt value) => true;

        public static bool IsComplexNumber(OutrageousInt value) => false;

        public static bool IsEvenInteger(OutrageousInt value) => int.IsEvenInteger(value.Value);

        public static bool IsFinite(OutrageousInt value) => true;

        public static bool IsImaginaryNumber(OutrageousInt value) => false;

        public static bool IsInfinity(OutrageousInt value) => false;

        public static bool IsInteger(OutrageousInt value) => true;

        public static bool IsNaN(OutrageousInt value) => false;

        public static bool IsNegative(OutrageousInt value) => int.IsNegative(value.Value);

        public static bool IsNegativeInfinity(OutrageousInt value) => false;

        public static bool IsNormal(OutrageousInt value) => true;

        public static bool IsOddInteger(OutrageousInt value) => int.IsOddInteger(value.Value);

        public static bool IsPositive(OutrageousInt value) => int.IsPositive(value.Value);

        public static bool IsPositiveInfinity(OutrageousInt value) => false;

        public static bool IsRealNumber(OutrageousInt value) => true;

        public static bool IsSubnormal(OutrageousInt value) => false;

        public static bool IsZero(OutrageousInt value) => value == Zero;

        public static OutrageousInt MaxMagnitude(OutrageousInt x, OutrageousInt y) 
            => new(int.MaxMagnitude(x.Value, y.Value));

        public static OutrageousInt MaxMagnitudeNumber(OutrageousInt x, OutrageousInt y) 
            => MaxMagnitude(x, y);

        public static OutrageousInt MinMagnitude(OutrageousInt x, OutrageousInt y) 
            => new(int.MinMagnitude(x.Value, y.Value));

        public static OutrageousInt MinMagnitudeNumber(OutrageousInt x, OutrageousInt y) 
            => MinMagnitude(x, y);

        public static bool TryConvertFromChecked<TOther>(TOther value, out OutrageousInt result)
            where TOther : INumberBase<TOther>
        {
            if (typeof(TOther) == typeof(double))
            {
                double actualValue = (double)(object)value;
                result = new OutrageousInt(checked((int)actualValue));
                return true;
            }
            else if (typeof(TOther) == typeof(Half))
            {
                Half actualValue = (Half)(object)value;
                result = new OutrageousInt(checked((int)actualValue));
                return true;
            }
            else if (typeof(TOther) == typeof(short))
            {
                short actualValue = (short)(object)value;
                result = new OutrageousInt(checked((int)actualValue));
                return true;
            }
            else if (typeof(TOther) == typeof(int))
            {
                int actualValue = checked((int)(object)value);
                result = new OutrageousInt(actualValue);
                return true;
            }
            else if (typeof(TOther) == typeof(long))
            {
                long actualValue = (long)(object)value;
                result = new OutrageousInt(checked((int)actualValue));
                return true;
            }
            else if (typeof(TOther) == typeof(Int128))
            {
                Int128 actualValue = (Int128)(object)value;
                result = new OutrageousInt(checked((int)actualValue));
                return true;
            }
            else if (typeof(TOther) == typeof(nint))
            {
                nint actualValue = (nint)(object)value;
                result = new OutrageousInt(checked((int)actualValue));
                return true;
            }
            else if (typeof(TOther) == typeof(sbyte))
            {
                sbyte actualValue = (sbyte)(object)value;
                result = new OutrageousInt(checked((int)actualValue));
                return true;
            }
            else if (typeof(TOther) == typeof(float))
            {
                float actualValue = (float)(object)value;
                result = new OutrageousInt(checked((int)actualValue));
                return true;
            }
            else
            {
                result = OutrageousInt.Zero;
                return false;
            }
        }

        public static bool TryConvertFromSaturating<TOther>(TOther value, out OutrageousInt result)
            where TOther : INumberBase<TOther>
        {
            if (typeof(TOther) == typeof(double))
            {
                double actualValue = (double)(object)value;
                int resultInt = (actualValue >= int.MaxValue) ? int.MaxValue :
                    (actualValue <= int.MinValue) ? int.MinValue : (int)actualValue;
                result = new OutrageousInt(resultInt);
                return true;
            }
            else if (typeof(TOther) == typeof(Half))
            {
                Half actualValue = (Half)(object)value;
                int resultInt = (actualValue == Half.PositiveInfinity) ? int.MaxValue :
                    (actualValue == Half.NegativeInfinity) ? int.MinValue : (int)actualValue;
                result = new OutrageousInt(resultInt);
                return true;
            }
            else if (typeof(TOther) == typeof(short))
            {
                short actualValue = (short)(object)value;
                result = new OutrageousInt(actualValue);
                return true;
            }
            else if (typeof(TOther) == typeof(int))
            {
                int actualValue = (int)(object)value;
                result = new OutrageousInt(actualValue);
                return true;
            }
            else if (typeof(TOther) == typeof(long))
            {
                long actualValue = (long)(object)value;
                int resultInt = (actualValue >= int.MaxValue) ? int.MaxValue :
                    (actualValue <= int.MinValue) ? int.MinValue : (int)actualValue;
                result = new OutrageousInt(resultInt);
                return true;
            }
            else if (typeof(TOther) == typeof(Int128))
            {
                Int128 actualValue = (Int128)(object)value;
                int resultInt = (actualValue >= int.MaxValue) ? int.MaxValue :
                    (actualValue <= int.MinValue) ? int.MinValue : (int)actualValue;
                result = new OutrageousInt(resultInt);
                return true;
            }
            else if (typeof(TOther) == typeof(nint))
            {
                nint actualValue = (nint)(object)value;
                int resultInt = (actualValue >= int.MaxValue) ? int.MaxValue :
                    (actualValue <= int.MinValue) ? int.MinValue : (int)actualValue;
                result = new OutrageousInt(resultInt);
                return true;
            }
            else if (typeof(TOther) == typeof(sbyte))
            {
                sbyte actualValue = (sbyte)(object)value;
                result = new OutrageousInt(actualValue);
                return true;
            }
            else if (typeof(TOther) == typeof(float))
            {
                float actualValue = (float)(object)value;
                int resultInt = (actualValue >= int.MaxValue) ? int.MaxValue :
                    (actualValue <= int.MinValue) ? int.MinValue : (int)actualValue;
                result = new OutrageousInt(resultInt);
                return true;
            }
            else
            {
                result = OutrageousInt.Zero;
                return false;
            }
        }

        public static bool TryConvertFromTruncating<TOther>(TOther value, out OutrageousInt result)
            where TOther : INumberBase<TOther>
        {
            if (typeof(TOther) == typeof(double))
            {
                double actualValue = (double)(object)value;
                int resultInt = (actualValue >= int.MaxValue) ? int.MaxValue :
                    (actualValue <= int.MinValue) ? int.MinValue : (int)actualValue;
                result = new OutrageousInt(resultInt);
                return true;
            }
            else if (typeof(TOther) == typeof(Half))
            {
                Half actualValue = (Half)(object)value;
                int resultInt = (actualValue == Half.PositiveInfinity) ? int.MaxValue :
                    (actualValue == Half.NegativeInfinity) ? int.MinValue : (int)actualValue;
                result = new OutrageousInt(resultInt);
                return true;
            }
            else if (typeof(TOther) == typeof(short))
            {
                short actualValue = (short)(object)value;
                result = new OutrageousInt(actualValue);
                return true;
            }
            else if (typeof(TOther) == typeof(int))
            {
                int actualValue = (int)(object)value;
                result = new OutrageousInt(actualValue);
                return true;
            }
            else if (typeof(TOther) == typeof(long))
            {
                long actualValue = (long)(object)value;
                int resultInt = (int)actualValue;
                result = new OutrageousInt(resultInt);
                return true;
            }
            else if (typeof(TOther) == typeof(Int128))
            {
                Int128 actualValue = (Int128)(object)value;
                int resultInt = (int)actualValue;
                result = new OutrageousInt(resultInt);
                return true;
            }
            else if (typeof(TOther) == typeof(nint))
            {
                nint actualValue = (nint)(object)value;
                int resultInt = (int)actualValue;
                result = new OutrageousInt(resultInt);
                return true;
            }
            else if (typeof(TOther) == typeof(sbyte))
            {
                sbyte actualValue = (sbyte)(object)value;
                result = new OutrageousInt(actualValue);
                return true;
            }
            else if (typeof(TOther) == typeof(float))
            {
                float actualValue = (float)(object)value;
                int resultInt = (actualValue >= int.MaxValue) ? int.MaxValue :
                    (actualValue <= int.MinValue) ? int.MinValue : (int)actualValue;
                result = new OutrageousInt(resultInt);
                return true;
            }
            else
            {
                result = OutrageousInt.Zero;
                return false;
            }
        }

        public static bool TryConvertToChecked<TOther>(OutrageousInt value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            if (typeof(TOther) == typeof(byte))
            {
                byte actualValue = checked((byte)value.Value);
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(char))
            {
                char actualValue = checked((char)value.Value);
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(decimal))
            {
                decimal actualValue = checked((decimal)value.Value);
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(ushort))
            {
                ushort actualValue = checked((ushort)value.Value);
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(uint))
            {
                uint actualValue = checked((uint)value.Value);
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(ulong))
            {
                ulong actualValue = checked((ulong)value.Value);
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(UInt128))
            {
                UInt128 actualValue = checked((UInt128)value.Value);
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(nuint))
            {
                nuint actualValue = checked((nuint)value.Value);
                result = (TOther)(object)actualValue;
                return true;
            }
            else
            {
                result = TOther.Zero;
                return false;
            }
        }

        public static bool TryConvertToSaturating<TOther>(OutrageousInt value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            if (typeof(TOther) == typeof(byte))
            {
                byte actualValue = (value.Value >= byte.MaxValue) ? byte.MaxValue :
                                    (value.Value <= byte.MinValue) ? byte.MinValue : (byte)value.Value;
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(char))
            {
                char actualValue = (value.Value >= char.MaxValue) ? char.MaxValue :
                                    (value.Value <= char.MinValue) ? char.MinValue : (char)value.Value;
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(decimal))
            {
                decimal actualValue = value.Value;
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(ushort))
            {
                ushort actualValue = (value.Value >= ushort.MaxValue) ? ushort.MaxValue :
                                    (value.Value <= ushort.MinValue) ? ushort.MinValue : (ushort)value.Value;
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(uint))
            {
                uint actualValue = (value.Value <= 0) ? uint.MinValue : (uint)value.Value;
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(ulong))
            {
                ulong actualValue = (value.Value <= 0) ? ulong.MinValue : (ulong)value.Value;
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(UInt128))
            {
                UInt128 actualValue = (value.Value <= 0) ? UInt128.MinValue : (UInt128)value.Value;
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(nuint))
            {
                nuint actualValue = (value.Value <= 0) ? nuint.MinValue : (nuint)value.Value;
                result = (TOther)(object)actualValue;
                return true;
            }
            else
            {
                result = TOther.Zero;
                return false;
            }
        }

        public static bool TryConvertToTruncating<TOther>(OutrageousInt value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            if (typeof(TOther) == typeof(byte))
            {
                byte actualValue = (byte)value.Value;
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(char))
            {
                char actualValue = (char)value.Value;
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(decimal))
            {
                decimal actualValue = value.Value;
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(ushort))
            {
                ushort actualValue = (ushort)value.Value; 
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(uint))
            {
                uint actualValue = (uint)value.Value;
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(ulong))
            {
                ulong actualValue = (ulong)value.Value;
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(UInt128))
            {
                UInt128 actualValue = (UInt128)value.Value;
                result = (TOther)(object)actualValue;
                return true;
            }
            else if (typeof(TOther) == typeof(nuint))
            {
                nuint actualValue = (nuint)value.Value;
                result = (TOther)(object)actualValue;
                return true;
            }
            else
            {
                result = TOther.Zero;
                return false;
            }
        }
    }
}
