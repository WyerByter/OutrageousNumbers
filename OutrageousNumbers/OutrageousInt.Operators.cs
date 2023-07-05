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

        public static OutrageousInt operator +(OutrageousInt left, OutrageousInt right) 
            => new(left.Value + right.Value);

        public static OutrageousInt operator checked +(OutrageousInt left, OutrageousInt right)
            => new(checked(left.Value + right.Value));

        public static OutrageousInt operator -(OutrageousInt value) => new(value.Value * -1);

        public static OutrageousInt operator -(OutrageousInt left, OutrageousInt right) 
            => new(left.Value - right.Value);

        public static OutrageousInt operator checked -(OutrageousInt left, OutrageousInt right)
            => new(checked(left.Value - right.Value));

        public static OutrageousInt operator ++(OutrageousInt value) => new(++value.Value);

        public static OutrageousInt operator checked ++(OutrageousInt value) => new(checked(++value.Value));

        public static OutrageousInt operator --(OutrageousInt value) => new(--value.Value);

        public static OutrageousInt operator checked --(OutrageousInt value) => new(checked(--value.Value));

        public static OutrageousInt operator *(OutrageousInt left, OutrageousInt right) 
            => new(left.Value * right.Value);

        public static OutrageousInt operator checked *(OutrageousInt left, OutrageousInt right)
            => new(checked(left.Value * right.Value));

        public static OutrageousInt operator /(OutrageousInt left, OutrageousInt right) 
            => new(left.Value / right.Value);

        public static OutrageousInt operator checked /(OutrageousInt left, OutrageousInt right)
            => new(checked(left.Value / right.Value));

        public static OutrageousInt operator %(OutrageousInt left, OutrageousInt right) 
            => new(left.Value % right.Value);
    }
}
