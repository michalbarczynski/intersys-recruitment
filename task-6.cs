using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        /* method that checks whether the arrays have the same lengths and after sorting are equal to each other
         - a necessary condition for a permutation to occur */
        public static bool arrComparison(int[] arr1, int[] arr2)
        {
            int n = arr1.Length;
            int m = arr2.Length;

            // checking if the lengths of both arrays are the same 
         
            if (n != m)
                return false;

            // sorting both arrays
            Array.Sort(arr1);
            Array.Sort(arr2);

            // comparison all elements of both arrays
            for (int i = 0; i < n; i++)
                if (arr1[i] != arr2[i])
                    return false;

            // if all elements of both arrays are the same
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Pass the size of the first array:");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Pass the size of the second array:");
            int n = int.Parse(Console.ReadLine());

            int[] arr1 = new int[m];
            int[] arr2 = new int[n];

            // arrays are different
            if (m != n)
            {
                Console.WriteLine("Error: there is no possibility for permutations to occur");
                Console.ReadKey();
                Environment.Exit(0); 
            }

            // loading elements of arrays
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("Pass " + (i + 1) + " element of the first array:");
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine("Pass " + (i + 1) + " element of the second array:");
                arr2[i] = int.Parse(Console.ReadLine());
            }

            // printing the elements of arrays 1 and 2 passed by the user
            Console.WriteLine("Passed:");
          
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i]);
            }
            Console.WriteLine();

            // calling the method that checks if the arrays are the same after sorting
            if (arrComparison(arr1, arr2))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");


            Console.ReadKey();
        }
    }
}