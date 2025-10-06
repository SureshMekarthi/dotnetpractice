using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    public class GenericList<T>
    {
        List<T> list;
        public GenericList()
        {
            list = new List<T>();
        }

        public void Add(T value)
        {
            list.Add(value);
        }

        public void Print()
        {
            foreach (T value in list)
            {
                Console.WriteLine(value);
            }
        }
    }
}
