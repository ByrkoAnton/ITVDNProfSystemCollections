using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SystemCollectionsAdditional
{
    public class DescendingComparer: IComparer
    {
        public int Compare(object? x, object? y)
        {
            CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
            int result = comparer.Compare(y, x);
            return result;
        }
    }
}
