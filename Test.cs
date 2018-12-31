using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_properties
{
    class Test
    {
        public static int count;
        

        public Test()
        {
            Test.count++;
        }
       static Test()
        {
            Test.count = 10;
        }

    }
}
