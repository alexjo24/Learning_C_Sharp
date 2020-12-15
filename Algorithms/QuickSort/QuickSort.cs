
public static class QuickSort
{

    /*
    How does the algorithm work?
    It picks some value as a pivot.
    Reorders the array such that values lower or equal to the pivot are placed before it (lower subarray)
    Values greater than the pivot are placed after it (higher subarray)
    This process is called partitioning. Using Hoare partition scheme.
    The algorithm recursively sorts each of the subarrays.
    Each subarray is further divided into the next two subarrays and so on.
    The recursion stops when there are one or zero elements left in a subarray.
    */
    static QuickSort(){
        System.Console.WriteLine("\nQuicksort started .... ");

    }

    public static int[] Run(int[] arr){
        int low = 0;
        int high = arr.Length-1;

        Sort(arr,low,high);

        return arr;
    }


    private static void Sort(int[] arr, int low, int high){

        //Run as long as low is less than high. Otherwise will return out of recursion loop.
        if (low < high){
            int pivot = (low+high)/2; //Set pivot id to a element in the middle of the array or close to the middle depending on the size. 
            int pivot_tmp = Partition(arr,low,high,pivot); //Partition the array. Output where to divide the array into subarrays. 

            
            //Recursively call on the sort method again to partition subarrays. Pivot_tmp decides where to divide into subarrays.
            Sort(arr,low,pivot_tmp);//Lower subarray
            Sort(arr,pivot_tmp+1,high); //Higher subarray

        }else{
            return;
        }
    }


    // Partition an given array. Swaps values between elements given an pivot and two pointers.
    /*
    *L = "Low" pointer
    *P = Pivot
    *H = "High" pointer

    *L starts in the beginning of the array and *H starts in the end of the array. 
    
    --> [ 9 , 2 , -4 , 5 , -1 , 1 , 6 , 2 , -4 , 9 , 2 ]
         *L                     *P                   *H

    *L pointer starts moving first and when *L = value which is bigger than the pivot value. *L pointer stops.
    *H pointer starts moving until *H = value which is smaller than the pivot value.

    Now we swap values between *L and *H.

    When this is done, *L > High, return *H pointer. 
    This is used as a limiter for the next subarray in the recursion loop, in the method Sort.

    */

    private static int Partition(int[] arr, int low, int high, int pivot){

 
        while(low<=high){
            
            while (arr[low] < arr[pivot]){
                low++;
            }

            while (arr[pivot] < arr[high]){
                high--;
            }

            //Break while loop if low index is equal to or bigger than high
            if (low >= high){
                break;
            }

            //Swap values between arr[low] and arr[high].    
            SwapValues(arr, low, high);
            low++;
            high--;
 
            
        }

        return high;
        
        
        
        //Code below is one of my tries to get Partition to work.
        
        // System.Console.WriteLine("####################################################");
        // System.Console.WriteLine("####################################################");
        // System.Console.WriteLine();
        // System.Console.Write("Arr: " );
        // foreach (int el in arr){
        //     System.Console.Write(el + " ");
        // }
        // System.Console.WriteLine();
        // System.Console.WriteLine("low: " + low);
        // System.Console.WriteLine("high: " + high);
        // System.Console.WriteLine("pivot value: " + arr[pivot]);

        // bool move_high_pointer = true;

        // while(low < high){
        //     System.Console.WriteLine();
        //     System.Console.WriteLine("______________________________________________________");
        //     System.Console.WriteLine("Pivot value: " + arr[pivot]);
        //     System.Console.WriteLine("Current low: " + low + ", Current arr[low]: " + arr[low]);
        //     System.Console.WriteLine("Current high: " + high + ", Current arr[high]: " + arr[high]);


        //     if(arr[low] > arr[pivot]){
        //         move_high_pointer = true;
                
        //         while(move_high_pointer){

        //             if(arr[high] < arr[pivot]){
        //                 SwapValues(arr,low,high);
        //                 high--;
        //                 low++;
        //                 move_high_pointer = false;
        //             }else{ 
        //                 high--;
        //             }
        //         }
        //     }else{
        //         low++;
        //     }
        // }
        // return high;
    }

    //Method to swap values in an array between two given indices.
    private static void SwapValues(int[] arr, int low, int high){
        int tmpVal = arr[low];
        arr[low] = arr[high];
        arr[high] = tmpVal;

    }

}
