using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    public class LinkedList
    {
        private Node _head;

        public LinkedList Add(int data)
        {
            var node = new Node(data);
            if(_head is null)
            {
                _head = node;
            }
            else
            {
                _head.Add(node);
            }
            return this;
        }

        public LinkedList Reverse()
        {
            var current = _head;
            Node previous = null;
            while(current is not null)
            {
                var next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }
            _head = previous;
            return this;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            var current = _head;
            while(current is not null)
            {
                sb.Append($"{current}{(current.Next is not null ? " -> " : string.Empty)}");
                current = current.Next;
            }
            return sb.ToString();
        }
    }
}
