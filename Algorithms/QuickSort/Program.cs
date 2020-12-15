using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random rnd = new Random();
            // int Min = -10;
            // int Max = 10;
            // int[] randomArr = new int[Max];

            // for (int i = 0; i < Max; i++){
            //     randomArr[i] = rnd.Next(Min,Max);
            // }
            
            // System.Console.WriteLine("\nArray to be sorted: ");
            // foreach (int el in randomArr){
            //     System.Console.Write(el + " ");
                
            // }
            // System.Console.WriteLine("\nSize of array: " + randomArr.Length);


            int[] testArr = new int[] {9, 2 , -4, 5, -1, 1, 6, 2, -4, 9, 2};


            System.Console.WriteLine("\nArray to be sorted: ");
            foreach (int el in testArr){
                System.Console.Write(el + " ");
                
            }
            System.Console.WriteLine("\nSize of array: " + testArr.Length);
            
            int[] sortedArr = QuickSort.Run(testArr);
            System.Console.WriteLine("\nSorted Array in Ascending order : ");
            foreach (int el in sortedArr){
                System.Console.Write(el + " ");
                
            }
        }
    }
}
