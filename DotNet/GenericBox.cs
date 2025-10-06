using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    public class GenericBox<T>
    {
        private  T Value;

        public void SetValue(T value)
        {
            Value = value;
        }

        public T GetValue()
        {
            return Value;
        }

        public T Print(T item)
        {
            Console.WriteLine(item);
            return item;
        }
    }
}
