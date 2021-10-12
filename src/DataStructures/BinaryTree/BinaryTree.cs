using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinaryTree
{
    public class BinaryTree
    {
        private Node _root;

        public BinaryTree Add(int data)
        {
            var node = new Node(data);
            if(_root is null)
            {
                _root = node;
            }
            else
            {
                _root.Add(node);
            }
            return this;
        }

        public void ForEach(Action<Node> action)
        {
            if(_root is not null)
            {
                _root.ForEach(action);
            }
        }

        public BinaryTree Reverse()
        {
            if(_root is not null)
            {
                _root.Reverse();
            }
            return this;
        }
    }
}
