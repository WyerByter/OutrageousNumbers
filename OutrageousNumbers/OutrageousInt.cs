using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;

namespace OutrageousNumbers
{
    public partial class OutrageousInt : INumber<OutrageousInt>
    {
        public OutrageousInt() => Value = Zero.Value;

        public OutrageousInt(int value) => Value = value;

        public OutrageousInt(OutrageousInt value) => Value = value.Value;

        private int Value { get; set; }
    }
}