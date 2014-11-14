using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            TextStats("who is your daddy and what does he do?");
            TextStats("its not a tumor");
            TextStats("kindergarten cop is a fantastic film.  It has truely passed the test of time.");
            Console.ReadKey();
        }

        static void TextStats(string inputString)
        {
            //display the input string
            Console.WriteLine("Input: {0}", inputString);
            //display the # of characters
            Console.WriteLine("# of Chars: {0}", inputString.Replace(" ", "").Length);
            //display the # of words
            Console.WriteLine("# of Words: {0}", inputString.Split(' ').Length);
            //display the # of vowels
            Console.WriteLine("# of Vowels: {0}", inputString.Count(x => "aeiou".Contains(char.ToLower(x))));
            //display the # of consonants
            Console.WriteLine("# of Consonants: {0}", inputString.Count(x => "bcdfghjklmnpqrstvwxyz".Contains(char.ToLower(x))));
            //display the # of special characters
            Console.WriteLine("# of Spec Chars: {0}", inputString.Count(x => !char.IsLetter(x)));
            //display the longest word
            Console.WriteLine("Longest Word: {0}", inputString.Replace("  ", " ").Split(' ').OrderByDescending(x => x.Length).First());
            //display the shortest worde
            Console.WriteLine("Shortest Word: {0}", inputString.Replace("  ", " ").Split(' ').OrderBy(x => x.Length).First());
            Console.WriteLine("\n\n");
        }
    }
}
