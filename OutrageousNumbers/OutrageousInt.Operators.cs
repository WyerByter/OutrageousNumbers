using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutrageousNumbers
{
    public partial class OutrageousInt
    {
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
    }
}
