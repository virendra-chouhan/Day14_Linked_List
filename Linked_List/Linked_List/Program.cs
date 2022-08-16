using System;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Welcome_To_LinkedList***");
            List list = new List();
            Console.WriteLine("Adding into List");
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Display();
            Console.ReadLine();
        }
    }
} 
