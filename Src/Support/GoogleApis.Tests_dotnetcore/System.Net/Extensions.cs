using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Net
{
    static class Extensions
    {
        public static bool EndsWith<T>(this IList<T> list, IList<T> endsWith)
        {
            int listOffset = list.Count - endsWith.Count;
            if (listOffset < 0)
            {
                return false;
            }
            var comparer = EqualityComparer<T>.Default;
            for (int i = 0; i < endsWith.Count; i++)
            {
                if (!comparer.Equals(list[listOffset + i], endsWith[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
