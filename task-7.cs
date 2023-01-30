using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            // loading numbers count
            Console.WriteLine("Pass the amount of numbers ");
            int n = int.Parse(Console.ReadLine());

            int[] tab = new int[n];

            // loading the numbers
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine("Pass " + (i + 1) + " numbers: ");
                tab[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            int result = 0;
        
            foreach (int x in tab)
            {
                result |= x;
            };

            for (int i = 0; i < 32; i++)
            {
                int power = 1 << i;
                if ((result & power) != 0)
                {
                    Console.WriteLine(power);
                }             
            }
           
            Console.ReadKey();
        }
    }
}