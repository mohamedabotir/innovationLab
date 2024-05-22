using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5.topics.C_8
{
    internal class TypeCheck
    {
        private object dbResource = "";
        public TypeCheck()
        {
            if (dbResource is string s)
            {
                Console.WriteLine(s);

            }

        }
    }
}
