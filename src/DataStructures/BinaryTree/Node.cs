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
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data) => _data = data;

        public void Add(Node node)
        {
            if(node._data < this._data)
            {
                if(this.Left is null)
                {
                    this.Left = node;
                }
                else
                {
                    this.Left.Add(node);
                }
            }
            else
            {
                if(this.Right is null)
                {
                    this.Right = node;
                }
                else
                {
                    this.Right.Add(node);
                }
            }
        }

        public void ForEach(Action<Node> action)
        {
            if(this.Left is not null)
            {
                this.Left.ForEach(action);
            }
            action(this);
            if(this.Right is not null)
            {
                this.Right.ForEach(action);
            }
        }

        public override string ToString() => _data.ToString();
    }
}
