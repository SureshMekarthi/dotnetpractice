using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    public class HashTableTest
    {
        public HashTableTest()
        {
            
        }

        public void Test()
        {
            Hashtable ht = new Hashtable();
            ht["one"] = "1";
            int value = Convert.ToInt32(ht["one"]);

            Console.WriteLine($"the value is {value}");
        }
    }
}
