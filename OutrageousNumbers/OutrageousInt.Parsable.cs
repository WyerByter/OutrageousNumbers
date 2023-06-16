using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace OutrageousNumbers
{
    public partial class OutrageousInt
    {
        public static OutrageousInt Parse(ReadOnlySpan<char> s, IFormatProvider? provider) => new(OutrageousInt.Parse(s, provider));

        public static OutrageousInt Parse(string s, IFormatProvider? provider) => new(OutrageousInt.Parse(s, provider));

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
    }
}