using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //loop from 1=>20 and pass 
            // each number into FizzBuzz()
            for (int i = 1; i <= 20; i++)
            {
                FizzBuzz(i);
            }

            Yodaizer("I like code.");

            TextStats("i went to a my little pony con last weekend, it was the jam, aka the cats meow.");

            for (int i = 2; i < 30; i++)
            {
                IsPrime(i);
            }

            DashInsert(8675309);
            DashInsert(55555555);
            Console.ReadKey();
        }

        static void FizzBuzz(int number)
        {
            //check if its divisible by 5 & 3
            if (number % 5 == 0 && number % 3 == 0)
            {
                //it is divisible by 5 & 3
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 5 == 0)
            {
                //it is divisible by 5
                Console.WriteLine("Fizz");
            }
            else if (number % 3 == 0)
            {
                //it is divisible by 3
                Console.WriteLine("Buzz");
            }
            else
            {
                //not divisible by any
                Console.WriteLine(number);
            }
        }

        static void Yodaizer(string text)
        {
            //break the string into words, removing any .'s using .Replace()
            List<string> wordList = text.Replace(".", "").Split(' ').ToList();
            if (wordList.Count() == 3)
            {
                Console.WriteLine(wordList[2] + ", " + wordList[0] + " " + wordList[1]);
            }
            else
            { 
                //loop over each word in reverse order
                for (int i = wordList.Count() - 1; i >= 0; i-- )
                {
                    //get the current word from the list
                    string currentWord = wordList[i];
                    //Write the to the console
                    Console.Write(currentWord + " ");
                }
                //add a blank line after the loop completes
                Console.WriteLine();
            }
        }

        static void TextStats(string input)
        {
            int numberOfCharacters = input.Length;
            int numberOfWords = input.Split(' ').Length;
            int numberOfVowels = 0;
            int numberOfConsonants = 0;
            int numberOfSpecialCharacters = 0;

            for (int i = 0; i < input.Length; i++)
            {
                //get a single letter from our string
                // convert it to lowercase for ease of use
                string aSingleLetter = input[i].ToString().ToLower();

                //is it a vowel?
                if ("aeiou".Contains(aSingleLetter))
                {
                    //its a vowel, lets count it
                    numberOfVowels++;
                }
                else if (" .?\\][()!@#$%^&".Contains(aSingleLetter)) 
                {
                    //its a spec char, count it
                    numberOfSpecialCharacters++;
                }
                else
                {
                    //if its not a vowel or spec 
                    // char, safe to assume its a
                    // consonant
                    numberOfConsonants++;
                }
            }
            //loop has completed, all letters
            // have been compared and counted
            //Time for output.

            Console.WriteLine("Input: " + input);
            Console.WriteLine("# of Characters: " + numberOfCharacters);
            Console.WriteLine("# of Words: " + numberOfWords);
            Console.WriteLine("# of Vowels: " + numberOfVowels);
            Console.WriteLine("# of Consonants: " + numberOfConsonants);
            Console.WriteLine("# of Special Characters: " + numberOfSpecialCharacters);

        }

        static void IsPrime(int number)
        {
            //set a boolean flag to indicate if its a prime
            // number or not.  assume its a prime until 
            // proven otherwise
            bool itsAPrimeNumber = true;

            //loop over each number between 1 and itself to 
            // test for divisibility
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    //its divisible by something, 
                    // so it is not a prime number
                    itsAPrimeNumber = false;
                    //its not a prime, no need to check anything
                    // else
                    break;
                }
            }
            //handle our output
            if (itsAPrimeNumber)
            {
                //is a prime
                Console.WriteLine(number + " is a prime number");
            }
            else
            {
                //not a prime
                Console.WriteLine(number);
            }
        }

        static void DashInsert(int number)
        {
            //we cant loop over each digit of a number, so 
            // we have to convert it to a string
            string numberString = number.ToString();
            //declare a string to hold some output
            string outputString = string.Empty;

            //loop over each of the digits, except the
            // last one
            for (int i = 0; i < numberString.Length - 1; i++)
            {
                int currentDigit = int.Parse(numberString[i].ToString());
                int nextDigit = int.Parse(numberString[i + 1].ToString());
                if (currentDigit % 2 != 0 && nextDigit % 2 != 0)
                {
                    //both odd, add the current digit and a dash
                    // to the output string
                    outputString += currentDigit + "-";
                }
                else
                {
                    //both digits are not odd
                    // add the current digit to the output
                    outputString += currentDigit;
                }
            }
            //our loop is complete, we've added all digits
            // but the last digit to our output string
            outputString += numberString[numberString.Length - 1];

            //time for output
            Console.WriteLine("Original: " + number);
            Console.WriteLine("Dashed Up: " + outputString);
        }
    }
}
