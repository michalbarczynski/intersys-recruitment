using System;

namespace Task12
{  
    class Program 
    { 
        static bool hasArray(int []A, int arr_size, int sum) 
        { 
            int l, r; 
            
            /* Sorting the elements */
            sort(A, 0, arr_size-1); 
            
            /* Looking for the numbers in the sorted array*/
            l = 0;
            r = arr_size-1;  
            while (l < r) 
            { 
                if(A[l] + A[r] == sum)
                {
                    return true;
                } 
                else if(A[l] + A[r] < sum) 
                {
                    l++; 
                }    
                else 
                {
                    // A[i] + A[j] > sum 
                    r--; 
                } 
            }  
            return false; 
        } 
        
        //Main code
        public static void Main() 
        { 
            int []A = {1, 4, 45, 6, 10, -8}; 
            int n = 16; 
            int arr_size = 6; 
            
            if (hasArray(A, arr_size, n)) 
            {
                Console.Write("Code executed successfully"); 
                Console.Write(hasArray[n]); 
            }    
            else
            {
                Console.Write("Code executed unsuccessfully"); 
            }
        } 
    } 
}