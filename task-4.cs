using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // loading the array size
            Console.WriteLine("Specify the size of the array:");
            int size = int.Parse(Console.ReadLine());
            int[] tab = new int[size];

            // loading elements of an array
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Specify " + (i + 1) + " element of the array:");
                tab[i] = int.Parse(Console.ReadLine());
            }

            // inputting the size of the array and the array elements specified by the user
            Console.WriteLine("Input:");
            Console.WriteLine(size);
            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i]);
            }
            Console.WriteLine();
            
            // reversing an array
            Console.WriteLine("Output:");
            for (int i = tab.Length; i > 0; i--)
            {
                Console.Write(tab[i-1]);  
            }
            Console.ReadLine();
        }
    }
}