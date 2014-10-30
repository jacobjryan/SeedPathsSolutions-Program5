using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetterFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            LetterFinder("t", "there are totally a lot of t's in this sentence. truely.");
            Console.ReadKey();
        }

        //create a new function for the letter finder
        static void LetterFinder(string letterToFind, string stringToSearch)
        {
            //declare a counter for the number of matches
            int letterMatchesFound = 0;
            //loop through each letter of the stringToSearch
            for (int i = 0; i < stringToSearch.Length; i = i + 1)
            {
                //gets a letter from the string, 
                // and converts it to lowercase
                string currentLetter = stringToSearch[i].ToString().ToLower();
                //do the letters match?
                if (currentLetter == letterToFind.ToLower())
                {
                    //found a match
                    letterMatchesFound = letterMatchesFound + 1;
                }

            }
            //print our output
            Console.WriteLine(stringToSearch + " has "
                + letterMatchesFound + " "
                + letterToFind + " in it.");
        }
    }
}
