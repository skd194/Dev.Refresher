using System;
using System.Collections.Generic;
using System.Linq;

namespace Preparation.Problem
{
    public static class CollectionExtensions
    {
        public static bool IsEquals<T>(this IEnumerable<T> collection1, IEnumerable<T> collection2)
            where T : struct
        {
            var array1 = collection1.ToArray();
            var array2 = collection2.ToArray();
            if (array1.Length != array2.Length) return false;

            for (int i = 0; i < array1.Length; i++)
            {
                if (!array1[i].Equals(array2[i])) return false;
            }
            return true;
        }

        public static string ToPrintableString<T>(this IEnumerable<T> collection)
            where T : struct
        {
            return $"[ {string.Join(',', collection)} ]";
        }

        public static void PrintLine<T>(this IEnumerable<T> collection, string prefix = "", string suffix = "")
            where T : struct
        {
            Console.WriteLine($"{prefix}{collection.ToPrintableString()}{suffix}");
        }
    }
}
