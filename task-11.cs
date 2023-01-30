using System; 

namespace Task11 
{
    class Program 
    {
        static int getOccurence(int n, int d) 
        {
            // Creating var result  
            int result = 0; 
        
            // Count appearances in numbers starting from d. 
            int itr = d; 
            while (itr <= n) 
            {   
                // When the last digit is equal to d 
                if (itr % 10 == d)
                {
                    result++; 
                }
                // When the first digit is equal to d then 
                if (itr != 0 && itr/10 == d) 
                {   
                    // increment result as well as number 
                    result++; 
                    itr++; 
                }           
            return result; 
            }
        } 
        
        // Driver code 
        public static void Main()  
        { 
            int n = 2, d = 20; 
            Console.Write(getOccurence(n, d)); 
        } 
    }
}
