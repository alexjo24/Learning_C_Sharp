using System;
using System.Linq;

public static class SelectionSort
{

    static SelectionSort(){
        System.Console.WriteLine("\nSelection Sort started .... ");

    }

    /*
    The algorithm divides the array into two parts, namely sorted and unsorted. 
    In the following iterations, the algorithm finds the smallest element in 
    the unsorted part and exchange it with the first element in the unsorted part.
    */
    public static int[] Run(int[] nonSortedArr){

        int[] sortedArr = new int[nonSortedArr.Length];

        int minVal = nonSortedArr[0];
        int minValIndex = 0;
        int maxVal = minVal;

        //1.Find largest int in nonSortedArr, used for reset of minVal variable.
        for (int i = 0; i < nonSortedArr.Length; i++){
            if (nonSortedArr[i] > maxVal){
                maxVal = nonSortedArr[i];
            }
        }

        for (int j = 0; j < sortedArr.Length; j++){

            //Reset minVal variable.
            minVal = maxVal;


            //2.Find smallest int in nonSortedArr
            for (int i = 0; i < nonSortedArr.Length; i++){
                if (nonSortedArr[i] < minVal){
                    minVal = nonSortedArr[i];
                    minValIndex = i;
                }
            }
            //3.Remove the current smallest element int in nonSortedArr
            //Using Linq -->
            nonSortedArr = nonSortedArr.Where((e,i) => i !=minValIndex).ToArray();

            //4.Insert the int in the next empty element in the sortedArr
            sortedArr[j] = minVal;
        }

 


        return sortedArr;
    }

    
    
}
