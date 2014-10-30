using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            int myAgeDoubled = DoubleIt(31);
            Console.WriteLine(DoubleIt(myAgeDoubled));
            
            //LoopTests();
            VowelCounter3000Tests();

            //keep the console open
            Console.ReadKey();
        }
        /// <summary>
        /// Writes "hello world" to the console
        /// </summary>
        static void HelloWorld()
        {
            Console.WriteLine("Hello World");
        }

        static int DoubleIt(int someNumber)
        {
            return someNumber * 2;
        }

        /// <summary>
        /// Prints numbers to the console from start to the end
        /// </summary>
        /// <param name="startNumber">number the loop starts end</param>
        /// <param name="endNumber">inclusive end point of the loop</param>
        static void LoopSomeNumbers(int startNumber, int endNumber)
        {
            for (int i = startNumber; i <= endNumber; i = i + 1)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Runs a series of tests on our 
        /// LoopSomeNumbers function
        /// </summary>
        static void LoopTests()
        {
            LoopSomeNumbers(5, 10);
            LoopSomeNumbers(863428, 863430);
            LoopSomeNumbers(31, DoubleIt(DoubleIt(31)));
        }

        /// <summary>
        /// Returns the number of vowels in a string
        /// </summary>
        /// <param name="inputString">A string that you want to count the number of vowels</param>
        /// <returns>The number of vowels found</returns>
        static int VowelCounter3000(string inputString)
        {
            //declare a counter for the vowels
            int numberOfVowelsFound = 0;

            //loop over each letter of the string
            for (int i = 0; i < inputString.Length; i = i + 1)
            {
                //take a letter from the string
                // and make it lowercase
                string letter = inputString[i].ToString().ToLower();

                if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
                {
                    //found a vowel!  huzzah!
                    numberOfVowelsFound = numberOfVowelsFound + 1;
                }

                //alternate way of checking to see if its
                // a vowel
                if ("aeiou".Contains(letter)) { }
            }

            //loop complete, time to write the output
            Console.WriteLine(inputString + " has " + numberOfVowelsFound + " vowels in it");
            return numberOfVowelsFound;
        }

        static void VowelCounter3000Tests()
        {
            //count the number of vowels counted
            int totalNumberOfVowelsCounted = 0;
            totalNumberOfVowelsCounted += VowelCounter3000("Jackie seems like a guy who might like Nickleback");
            totalNumberOfVowelsCounted += VowelCounter3000("I love to eat instant mashed potatoes.");
            Console.WriteLine("Total Vowels Counted: " + totalNumberOfVowelsCounted);
        }
    }
}
