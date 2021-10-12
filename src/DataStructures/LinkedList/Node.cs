using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.LinkedList
{
    internal class Node
    {
        private int _data;
        internal Node Next { get; set; }

        internal Node(int data) => _data = data;

        internal void Add(Node node)
        {
            if(Next is null)
            {
                Next = node;
            }
            else
            {
                Next.Add(node);
            }
        }

        public override string ToString() => _data.ToString();
    }
}
