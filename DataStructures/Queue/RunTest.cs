using System;

namespace RunTest
{

    class RunTest
        {
            public static void Main(string[] args){

                Queue<string> queueOfStrings = new Queue<string>();

                queueOfStrings.Enqueue("Dog");
                queueOfStrings.Enqueue("Cat");
                queueOfStrings.Enqueue("Mouse");
                queueOfStrings.Enqueue("Bird");

                System.Console.WriteLine("Foreach:");
                foreach(string item in queueOfStrings){
                    System.Console.WriteLine(item);
                }
                System.Console.WriteLine("\n");

                System.Console.WriteLine("Peek: "+queueOfStrings.Peek());
                System.Console.WriteLine("Dequeue : "+queueOfStrings.Dequeue());
                System.Console.WriteLine("Size of queue: "+queueOfStrings.Count());
                System.Console.WriteLine("Peek: "+queueOfStrings.Peek());

                System.Console.WriteLine("\n");
                System.Console.WriteLine("Foreach: ");
                foreach(string item in queueOfStrings){
                    System.Console.WriteLine(item);
                }

                System.Console.WriteLine("Clearing queue... ");
                queueOfStrings.Clear();

                System.Console.WriteLine("Size of queue: "+queueOfStrings.Count());
                


            }
        }
}
