// /*
// Copyright 2011 Google Inc
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// */
using System;
using System.Collections;

using NUnit.Framework;

namespace Google.Apis.Testing
{
    public class MoreAsserts
    {
        public static void ContentsEqualAndInOrder(IEnumerable expected, IEnumerable actual)
        {
            var expectedEnum = expected.GetEnumerator();
            var actualEnum = actual.GetEnumerator();
            int index = 0;
            while(expectedEnum.MoveNext())
            {
                if(actualEnum.MoveNext() == false)
                {
                    Assert.Fail("Actual has less items then Expected at index " + index);
                }
                Assert.AreEqual(expectedEnum.Current, actualEnum.Current, "Found different elements at index " + index);
                index++;
            }
            if(actualEnum.MoveNext() == true)
            {
                Assert.Fail("Actual has more items then Expected at index " + index);
            }
        }
        
    }
}

