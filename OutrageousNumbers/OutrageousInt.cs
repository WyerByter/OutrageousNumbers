using System.Numerics;

namespace OutrageousNumbers
{
    public partial class OutrageousInt : INumber<OutrageousInt>
    {
        public OutrageousInt() => Value = Zero.Value;

        public OutrageousInt(int value) => Value = value;

        public OutrageousInt(OutrageousInt value) => Value = value.Value;

        public int Value { get; private set; }
    }
}