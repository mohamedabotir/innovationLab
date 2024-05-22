using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5.topics.C_9
{
    internal class initialize_required
    {
        public required string  Resource { get; init; }

        public initialize_required()
        {
            
        }

        
    }

    class program
    {
        public program()
        {
          var obj =   new initialize_required()
            {
                Resource = "12"
            };
            //obj.Resource = 12; not applicable
        }
    }
}
