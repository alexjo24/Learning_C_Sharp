using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int Min = -100;
            int Max = 100;
            int[] randomArr = new int[Max];

            for (int i = 0; i < Max; i++){
                randomArr[i] = rnd.Next(Min,Max);
            }
            
            System.Console.WriteLine("\nArray to be sorted: ");
            foreach (int el in randomArr){
                System.Console.Write(el + " ");
                
            }
            System.Console.WriteLine("\nSize of array: " + randomArr.Length);



            int[] sortedArr = InsertionSort.Run(randomArr);
            System.Console.WriteLine("\nSorted Array in Ascending order : ");
            foreach (int el in sortedArr){
                System.Console.Write(el + " ");
                
            }
        }
    }
}
