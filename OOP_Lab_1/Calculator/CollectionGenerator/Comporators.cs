using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionGenerator
{
    public class AscendingComporator : IComparer<Randomer>
    {
        public int Compare(Randomer x, Randomer y)
        {
            if (x.Value > y.Value)
            {
                return 1;
            }
            else if (x.Value < y.Value)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }

    public class DescendingComporator : IComparer<Randomer>
    {
        public int Compare(Randomer x, Randomer y)
        {
            if (x.Value < y.Value)
            {
                return 1;
            }
            else if (x.Value > y.Value)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }
    }
}
