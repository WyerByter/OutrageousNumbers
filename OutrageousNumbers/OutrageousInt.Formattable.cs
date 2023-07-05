namespace OutrageousNumbers
{
    public partial class OutrageousInt
    {
        public bool TryFormat(
            Span<char> destination,
            out int charsWritten,
            ReadOnlySpan<char> format,
            IFormatProvider? provider)
            => Value.TryFormat(destination, out charsWritten, format, provider);

        public string ToString(string? format, IFormatProvider? formatProvider) 
            => Value.ToString(format, formatProvider);
    }
}
