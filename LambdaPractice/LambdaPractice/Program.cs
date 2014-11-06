using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a funtime list
            List<string> funtimeList = new List<string>() { "blueberry", "apple", "boisonberry", "pear", "strawberry" };

            //print out each item in the funtime list
            // ordered alphabetically
            Console.WriteLine(string.Join(", ", funtimeList.OrderBy(x => x)));
            Console.WriteLine();

            //write to the console only the 
            //items containing the word berry
            Console.WriteLine(string.Join(", ", funtimeList.Where(x => x.Contains("berry"))));

            //write all the non-berry items
            // ordered by the length of the string
            Console.WriteLine(string.Join(", ", funtimeList.Where(x => !x.Contains("berry")).OrderBy(x => x.Length)));

            //write only the items that have
            // 5 or more characters
            Console.WriteLine(string.Join(", ", funtimeList.Where(x => x.Length >= 5)));
            
            //write the total number of characters
            // in the funtimeList to the console
            Console.WriteLine("Total number of Chars: " + funtimeList.Sum(x => x.Length));

            //write the average number of characters
            // in the funtimeList to the console?
            Console.WriteLine("Average number of Chars: " + funtimeList.Average(x => x.Length));
            
            //write to the console, the number of 
            // vowels in each item in the funtimeList
            Console.WriteLine(string.Join("\n", funtimeList.Select(x => x + " has " + x.Count(y => "aeiou".Contains(y)) + " vowels")));

            //vowel counter by itself on a single string
            string countMyVowels = "beef hardchest and rocksteady 7";
            int numberOfVowels = countMyVowels.Count(x => "aeiou".Contains(x.ToString().ToLower()));
            Console.WriteLine(countMyVowels + " has " + numberOfVowels + " vowel(s) in it.");
            Console.ReadKey();
        }
    }
}
