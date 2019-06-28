using System;

namespace Midnite81.HelperExtensions
{
    public static class NullableExtensions
    {
        public static bool IsNull(this object obj)
        {
            return obj == null;
        }

        public static bool IsNotNull(this object obj)
        {
            return obj != null;
        }

        public static bool HasValueEqualTo<TOriginal, TValue>(this TOriginal? original, TValue equalTo) 
        where TOriginal : struct where TValue : IComparable
        {
            return original.HasValue && original.Value.Equals(equalTo);
        }
    }
}

