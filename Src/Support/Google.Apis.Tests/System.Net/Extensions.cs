/*
Copyright 2017 Google Inc

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
*/

#if NETCOREAPP1_0 || NETCOREAPP1_1

using System.Collections.Generic;

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

#elif NET452 || NET46
// Nothing required
#else
#error Unsupported platform
#endif
