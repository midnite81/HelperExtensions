using System;
using System.Collections.Generic;
using System.Linq;

namespace Midnite81.HelperExtensions
{
    public static class ArrayableExtensions
    {
        public static bool IsOneOf<TOriginal, TArray>(this TOriginal original, IEnumerable<TArray> items)
            where TOriginal : IComparable where TArray : IComparable
        {
            return items.Any(item => original.Equals(item));
        }
        
        public static bool IsOneOfCaseInsensitive<TOriginal, TArray>(this TOriginal original, IEnumerable<TArray> items)
            where TOriginal : IComparable where TArray : IComparable
        {
            return items.Any(item => original.ToString().ToLower().Equals(item.ToString().ToLower()));
        }
    }
}