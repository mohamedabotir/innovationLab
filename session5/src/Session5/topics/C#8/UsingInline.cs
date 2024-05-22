using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5.topics.C_8
{
    internal class UsingInline
    {
        public UsingInline()
        {
                using var reader = File.OpenText("numbers.txt");
             
                string line;
                while ((line = reader.ReadLine()) is not null)
                {
                   Console.WriteLine(line);
                }
             
        }
    }
}
