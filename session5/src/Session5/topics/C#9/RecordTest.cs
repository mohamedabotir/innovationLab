using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Session5.topics.C_9.RecordTest;

namespace Session5.topics.C_9
{
    internal class RecordTest
    {
        public record  Person
        {
            public  string FirstName { get; set; }
            public  string LastName { get; set; }
            public required string[] PhoneNumbers { get; init; }

            public void make()
            {
                Console.WriteLine("sd");
            }
        };

        internal record test(string a, string b);
        internal class test1(string a, string b);
    }

    class PersonUsage
    {
        public PersonUsage()
        {
          var rec=  new RecordTest.Person
          {
              FirstName = "",
              PhoneNumbers= new[] {""}
          };
          var d = new test("", "");
          var ll = new test1("","");
        }
    }
}
