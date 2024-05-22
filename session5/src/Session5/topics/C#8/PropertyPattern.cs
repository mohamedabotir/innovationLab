using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5.topics.C_8
{
    internal class PropertyPattern
    {
        public PropertyPattern()
        {
           var isEqual= new @readonly() is { X: >0 };
        }

        public struct @readonly
        {


            public readonly double Sum()
            {
                var x = 1;
                return X + Y;
            }

            public int Y { get; set; }

            public int X { get; set; }


        }
    }
}
