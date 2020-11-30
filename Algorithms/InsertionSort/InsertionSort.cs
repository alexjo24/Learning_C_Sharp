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
        int cc = 0; //Counter variable, used for stepping through the elements in the unsorted array.
        int ccInner; //Counter variable, used for stepping through the elements but inside the sorted array.
        bool search = true; //Used for stepping through the sorted array. 
        int tmpVal; //Temporary variable used for swapping values between the arrays.
        
        // Loop through the size of the nonsorted array. Starting the sorting process.
        while (cc < nonSortedArr.Length){
            
            //Simply store the first element value from the unsorted array to the sorted array. Only done in the first loop.
            if (cc == 0){

                sortedArr[cc] = nonSortedArr[cc];

            }else{

                // Check to see if element values between the two arrays needs to be swapped. 
                //Only swapped if the value in the nonsorterd array is less than the one in 
                //the sorted array for the current iteration (cc).
                if (sortedArr[cc-1] > nonSortedArr[cc]){

                    //Swap element value between the Sorted and Non-sorted Arrays
                    //e.g. 
                    // *current element index = n
                    // *previous element index = n-1
                    tmpVal = nonSortedArr[cc];
                    nonSortedArr[cc] = sortedArr[cc-1];
                    sortedArr[cc-1]= tmpVal;

                    

                        //Sort values within the sorted array
                        ccInner = cc-1;
                        while(search){
                            
                            //Check if counter is greater than 0. Used to prevent out of bounds index.
                            if (ccInner > 0){
                            
                                if (sortedArr[ccInner] < sortedArr[ccInner-1]){

                                        //Swap values between current element and previous element, only in the sorted array
                                        //e.g. 
                                        // *current element index = n
                                        // *previous element index = n-1
                                        tmpVal = sortedArr[ccInner];
                                        sortedArr[ccInner] = sortedArr[ccInner-1];
                                        sortedArr[ccInner-1] = tmpVal;
                                }else{
                                    search = false;
                                }

                            }else{
                                search = false;
                            }
                            
                            ccInner--; //Make sure the counter is decreased by one to take another step into the sorted array.
                        }
                        search = true; // Reset the search bool.
                    
                    sortedArr[cc] = nonSortedArr[cc];
                    
                }else{
                    sortedArr[cc] = nonSortedArr[cc];
                }

                
            }

            //Output for the user to see the sorting process.
            foreach (int el in sortedArr){
                System.Console.Write(el + " ");
                
            }
            System.Console.WriteLine("");



            cc ++; //Increase the counter by one. Enable another iteration in the outer for loop for stepping through the unsorted and sorted array.

        }

        return sortedArr;
    }

}
