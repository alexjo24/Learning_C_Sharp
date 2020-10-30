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
            listOfInts.ShowNodes();
            //Console.WriteLine("Size of the LinkedList: " + listOfInts.First());

        }

    }
}