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
            var rand = new RandomNumberGenerator(10);
            while(rand.HasNext())
            {
                var number = rand.Get();
                tree.Add(number);
                Console.Write($"{number} ");
            }
            Console.WriteLine();
            tree.ForEach(n => Console.Write($"{n} "));
            Console.WriteLine();
            tree.Reverse();
            tree.ForEach(n => Console.Write($"{n} "));
        }
    }
}
