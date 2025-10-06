using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    public class Stack1
    {
        private int[] _items;
        private int _top;
        private int _maxSize;

        public Stack1(int size)
        {
            _maxSize = size;
            _items = new int[size];
            _top = -1;

        }

        public void Push(int item)
        {
            if (_top == _maxSize - 1)
            {
                Console.WriteLine("Stack overflow");
                return;
            }
            _top++;
            _items[_top] = item;
            Console.WriteLine($" the new item pushed is {item}");
        }


        public int Pop()
        {
            if (_top == -1)
            {
                Console.WriteLine("Stack underflow");
                return -1;
            }

             int item = _items[_top];
            _top = _top-1;

            Console.WriteLine($" the item poped is {item}");
            return item;
        }

        public int Peek()
        {
            if (_top == -1)
            {
                Console.WriteLine("Stack underflow");
                return -1;
            }
            return _items[_top];

        }

    }
}
