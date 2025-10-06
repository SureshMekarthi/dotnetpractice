using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet
{
    public class Node
    {
        public int Data;
        public Node Next;

        public Node(int data) 
        {
            Data = data;
            Next = null;
        }
    }

    public class Stack
    {
        private Node _top;

        public Stack()
        {
            _top = null;
        }

        public void Push(int item) 
        {
            Node newNode = new Node(item);
            newNode.Next = _top;// to link the privious element
            _top = newNode;
            Console.WriteLine($"the new item pushed is {item}");
        }

        public void Pop()
        {
            int popedItem = _top.Data;// top->5->30->20->null= top->30->20>null
            _top = _top.Next;
           
            Console.WriteLine($"the new item pushed is {popedItem}");
        }

        public int Peek()
        {
            if( _top == null )
                return -1;
            return _top.Data;
        }
    }
}
