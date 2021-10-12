using DataStructures.BinaryTree;
using DataStructures.LinkedList;
using System;

namespace ConsolesAndScratches
{
    class Program
    {
        static void Main(string[] args)
        {
            TestLinkedList();
            TestBinaryTree();
            Console.ReadLine();
        }

        public static void TestLinkedList()
        {
            Console.WriteLine("Linked List");
            var list = new LinkedList();
            list.Add(3).Add(5).Add(7);
            Console.WriteLine(list);
            Console.WriteLine(list.Reverse());
        }

        public static void TestBinaryTree()
        {
            Console.WriteLine("Binary Tree");
            var tree = new BinaryTree();
            tree.Add(4).Add(1).Add(7).Add(3);
            tree.ForEach(n => Console.Write($"{n} "));
        }
    }
}
