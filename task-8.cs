using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            // loading the beginning and end of the range
            Console.WriteLine("Enter the beginning of the range");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Enter the end of the range");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // checking whether the conditions are met
            if ((m < 1) || (n < 1) || (m > n) || (n > 1000000000) || ((n - m) > 100000))
            {
                Console.Write("Error: invalid data");
                Console.ReadKey();
                Environment.Exit(0);
            }

            bool primeNumber = true;
            int result = 0;
            int j;

            // for all numbers from m to n
            for (int i = m; i <= n; i++)
            {
                // checking if a number is divisible NOT only by 1 and itself
                for (j = 2; j < i; j++)
                {
                    // if so it is NOT a prime number
                    if (i % j == 0)
                    {
                        primeNumber = false;
                    }
                }
             
                // printing all prime numbers in the interval from m to n
                // (i>1) because 1 is not a prime number
                if ((primeNumber == true) && (i > 1))
                {
                    Console.WriteLine("The prime number is: " + i);
                    result++; // counting the amount of prime numbers
                }

                else primeNumber = true;

            }

            // printing the amount of prime numbers in the range specified by the user
            Console.WriteLine("The prime numbers in range from" + m + " to " + n + " are: " + result);
            Console.ReadKey();
        }
    }
}
