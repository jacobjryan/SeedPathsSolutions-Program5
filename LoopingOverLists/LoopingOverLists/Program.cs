using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingOverLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LoopOverAList();
            LoopOverWordsInAString("the quick brown fox jumps over the lazy dog");
            Console.ReadKey();
        }

        static void LoopOverAList()
        {
            //create a list of sports
            List<string> sportsList = new List<string>() { "Baseball", "Tennis" };
            //add Football to the sportsList
            sportsList.Add("Football");
            //loop over the sportsList and display all
            // elements that contain the word "ball"
            for (int i = 0; i < sportsList.Count(); i = i + 1)
            {
                //get the current sport out of sportsList
                string currentSport = sportsList[i];
                //check to see if its a sport with the word 
                // "ball" in it
                if (currentSport.Contains("ball"))
                {
                    //its true
                    Console.WriteLine(currentSport);
                }
            }
 
        }

        /// <summary>
        /// Print out each word of a string, one per line
        /// </summary>
        /// <param name="inputString">String to loop over</param>
        static void LoopOverWordsInAString(string inputString)
        {
            List<string> wordList = inputString.Split(' ').ToList();
            for (int i = 0; i < wordList.Count(); i = i + 1)
            {
                Console.WriteLine(wordList[i]);
            }
        }
    }
}
