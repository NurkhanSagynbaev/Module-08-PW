using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_08_PW
{
    public class RangeOfArray

    {
        private int lowerIndex;
        private int upperIndex;

        public RangeOfArray(int lower, int upper)
        {
            lowerIndex = lower;
            upperIndex = upper;
        }

        public int this[int index]
        {
            get
            {
                if (index < lowerIndex || index > upperIndex)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                return index;
            }
            set
            {
                if (index < lowerIndex || index > upperIndex)
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
                
            }
        }
    }
}

 