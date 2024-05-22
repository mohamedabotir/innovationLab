using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5.topics.C_8
{
    public struct @readonly
    {
        #region for method

        public readonly double Sum()
        {
            return X + Y;
        }

        public int Y { get; set; }

        public int X { get; set; }

        #endregion
    }
}
