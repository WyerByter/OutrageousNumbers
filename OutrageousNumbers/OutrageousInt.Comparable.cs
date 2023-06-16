using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutrageousNumbers
{
    public partial class OutrageousInt
	{
        public int CompareTo(object? obj) => obj is OutrageousInt other
                ? CompareTo(other)
                : throw new ArgumentException("Object must be of type OutrageousInt", nameof(obj));

        public int CompareTo(OutrageousInt? other) => other is null ? 1 : Value.CompareTo(other.Value);

        public bool Equals(OutrageousInt? other) => other is not null && Value.Equals(other.Value);

        public static bool operator ==(OutrageousInt? left, OutrageousInt? right) => left?.Equals(right) ?? right is null;

        public static bool operator !=(OutrageousInt? left, OutrageousInt? right) => !(left == right);

        public static bool operator <(OutrageousInt left, OutrageousInt right) => ((IComparable<OutrageousInt>)left).CompareTo(right) < 0;

        public static bool operator >(OutrageousInt left, OutrageousInt right) => ((IComparable<OutrageousInt>)left).CompareTo(right) > 0;

        public static bool operator <=(OutrageousInt left, OutrageousInt right) => ((IComparable<OutrageousInt>)left).CompareTo(right) <= 0;

        public static bool operator >=(OutrageousInt left, OutrageousInt right) => ((IComparable<OutrageousInt>)left).CompareTo(right) >= 0;

        public override bool Equals(object? obj) => obj is OutrageousInt other && Equals(other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
