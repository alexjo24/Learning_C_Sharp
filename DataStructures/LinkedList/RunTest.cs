using System;

namespace RunTest
{
    class RunTest
    {
        public static void Main(string[] args){


            LinkedList<string> listOfStrings = new LinkedList<string>();
            listOfStrings.AddLast("Dog");
            listOfStrings.AddLast("Cat");
            listOfStrings.ShowNodes();

            LinkedList<int> listOfInts = new LinkedList<int>();
            listOfInts.AddLast(5);
            listOfInts.AddLast(10);
            listOfInts.ShowNodes();

            Console.WriteLine("Size of the LinkedList: " + listOfInts.Count());

            listOfInts.AddFirst(25);
            listOfInts.AddFirst(8);
            listOfInts.AddFirst(7);
            listOfInts.AddLast(10);
            listOfInts.AddLast(43);
            listOfInts.ShowNodes();
            
            Console.WriteLine("First node data in the linkedlist: " + listOfInts.First().data);
            Console.WriteLine("Last node data in the linkedlist: " + listOfInts.Last().data);

            Console.WriteLine("Find the first node with the corresponding input data: " + listOfInts.Find(10).data);
            Console.WriteLine("Find the first node with the corresponding input data: " + listOfInts.Find(9));

            System.Console.WriteLine(listOfInts.Remove(1));
            System.Console.WriteLine(listOfInts.Remove(7));
            System.Console.WriteLine(listOfInts.Remove(25));
            System.Console.WriteLine(listOfInts.Remove(43)); 
            listOfInts.ShowNodes();

        }

    }
}