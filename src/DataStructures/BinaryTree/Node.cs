using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.BinaryTree
{
    public class Node
    {
        private int _data;
        private Node _left;
        private Node _right;

        internal Node(int data) => _data = data;

        internal void Add(Node node)
        {
            if(node._data < this._data)
            {
                if(this._left is null)
                {
                    this._left = node;
                }
                else
                {
                    this._left.Add(node);
                }
            }
            else
            {
                if(this._right is null)
                {
                    this._right = node;
                }
                else
                {
                    this._right.Add(node);
                }
            }
        }

        internal void ForEach(Action<Node> action)
        {
            if(this._left is not null)
            {
                this._left.ForEach(action);
            }
            action(this);
            if(this._right is not null)
            {
                this._right.ForEach(action);
            }
        }

        internal void Reverse()
        {
            if(this._left is null && this._right is null)
            {
                return;
            }
            else
            {
                this.Swap();
                if(this._left is not null)
                {
                    this._left.Reverse();
                }
                if(this._right is not null)
                {
                    this._right.Reverse();
                }
            }
        }

        private void Swap()
        {
            var temp = this._left;
            this._left = this._right;
            this._right = temp;
        }

        public override string ToString() => _data.ToString();
    }
}
