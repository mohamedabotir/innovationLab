using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5.topics.C_8
{
    internal class indiciesAndRangesCountable
    {
        public indiciesAndRangesCountable()
        {
            int[]xs = new int[3]{1,2,3};
            Range endIndices = 0..3;

            Console.WriteLine(xs[^1]);
            Console.WriteLine(xs[0..3]);
        }
    }
}
