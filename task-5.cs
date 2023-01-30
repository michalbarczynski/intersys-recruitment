using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string word, reversedWord = "";

            // loading the word
            Console.WriteLine("Pass the word:");
            word = Console.ReadLine();

            // elimination of spaces, numbers and other characters
            Regex rgx = new Regex("[^a-zA-Z]");
            string newWord = rgx.Replace(word, "");

            // reversing a word
            for (int i = newWord.Length - 1; i >= 0; i--)
            {
                reversedWord += newWord[i];
            }
            
            //comparison of the passed word with the reversed one
            if (newWord == reversedWord)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            Console.ReadKey();
        }
    }
}