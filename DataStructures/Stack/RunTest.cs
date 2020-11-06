using System;

namespace RunTest
{

    class RunTest
        {
            public static void Main(string[] args){

                Stack<string> StackOfStrings = new Stack<string>();
                StackOfStrings.Push("Dog");
                StackOfStrings.Push("Cat");
                StackOfStrings.Push("Mouse");


                System.Console.WriteLine("for each loop functionality: \n");
                foreach (string item in StackOfStrings){
                    System.Console.WriteLine(item);
                }
                System.Console.WriteLine("________________________________");
                System.Console.WriteLine("Size of stack: "+StackOfStrings.Count());
                System.Console.WriteLine("Pop: "+StackOfStrings.Pop());
                System.Console.WriteLine("Size of stack: "+StackOfStrings.Count());
                System.Console.WriteLine("Peek: "+StackOfStrings.Peek());
                System.Console.WriteLine("Size of stack: "+StackOfStrings.Count());
                System.Console.WriteLine("Clearing the stack.");
                StackOfStrings.Clear();
                System.Console.WriteLine("Size of stack: "+StackOfStrings.Count());

                System.Console.WriteLine("________________________________");
                StackOfStrings.Push("Dog");
                StackOfStrings.Push("Cat");
                StackOfStrings.Push("Mouse");
                System.Console.WriteLine("Peek: "+StackOfStrings.Peek());
                System.Console.WriteLine("Size of stack: "+StackOfStrings.Count());
                
                


            }
        }
}