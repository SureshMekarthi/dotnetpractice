using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DotNet.DelegateTest;

namespace DotNet
{
    public class DelegateTest
    {

        public delegate void DelegateTestDelegate(string message);

        DelegateTestDelegate obj = null;
        public DelegateTest()
        {
           obj = new DelegateTestDelegate(ShowMessage);
        }

        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void Subscrib()
        {
           
            obj("test");
        }

        public DelegateTestDelegate GetDelegate()
        {
            return obj;
        }
    }

    public class DelegateTest2
    {
        public void callback(DelegateTestDelegate del)
        {
            del("hello");
        }
    }

    public class DelegateTest3
    {

    }
}
