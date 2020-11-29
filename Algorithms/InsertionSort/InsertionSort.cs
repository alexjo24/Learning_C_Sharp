using System;
using System.Linq;

public static class InsertionSort
{


    /*
    The algorithm divides the array into two parts, namely sorted and unsorted. 
    Similar to the selection sort. At the beginning, the first element is included
    in the sorted part. In each iteration, the algorithm takes the first element from
    the unsorted part and places it in a suitable location within the sorted part, to leave
    the sorted part in the correct order.
    */
    static InsertionSort(){
        System.Console.WriteLine("\nInsertion Sort started .... ");

    }

    public static int[] Run(int[] nonSortedArr){


        int[] sortedArr = new int[nonSortedArr.Length];
        int cc = 0;
        int tmpcc;
        bool search = true;
        int tmpVal;
        

        while (cc <= nonSortedArr.Length){
            
            
            if (cc == 0){

                sortedArr[cc] = nonSortedArr[cc];

            }else{


                if (nonSortedArr[cc] < sortedArr[cc-1]){

                    tmpVal = sortedArr[cc-1];
                    sortedArr[cc-1] = nonSortedArr[cc];
                    nonSortedArr[cc] = tmpVal;

                    if (cc > 1){
                        tmpcc = cc;
                        while(search){
                            
                            


                            if (sortedArr[tmpcc-1] < sortedArr[tmpcc-2]){

                                    tmpVal = sortedArr[tmpcc-1];
                                    sortedArr[tmpcc-1] = sortedArr[tmpcc-2];
                                    sortedArr[tmpcc-2] = tmpVal;
                                }
                        }

  
                    }else{
                        sortedArr[cc] = nonSortedArr[cc];
                    }
                    
                }else{
                    sortedArr[cc] = nonSortedArr[cc];
                }

                
            }
            
            //Remove the current smallest element int in nonSortedArr
            //Using Linq -->
            //nonSortedArr = nonSortedArr.Where((e,i) => i !=cc).ToArray();



            
            System.Console.WriteLine("Length of nonSortedArr: " + nonSortedArr.Length);
            foreach (int el in sortedArr){
                System.Console.Write(el + " ");
                
            }
            System.Console.WriteLine("");



            cc ++;

        }

        return sortedArr;
    }

}
