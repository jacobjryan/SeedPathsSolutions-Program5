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
            //tested this and it worked well also
            for (int n = 0; n <= 20; n++)
            {
                FizzBuzz(n);
            }
            int x = 0;
            while (x <= 20)
            {
                FizzBuzz(x);
                x++;
            }
            for (int j = 92; j >= 79; j = j - 1)
            {
                FizzBuzz(j);
            }
            int y = 92;
            while (y >= 79)
            {
                FizzBuzz(y);
                y = y - 1;
            }
            //tested this and it works well
            const string s1 = "I like code";
            string rev1 = Program.Yodaizer(s1);
            Console.WriteLine(rev1);

            TextStats("I mean, it's kind of a small horse. Am I missing something? Am I crazy?");



            Console.WriteLine("Primes between 1 and 25");
            for (int i = 1; i < 25; i++)
            {
                bool prime = IsPrime(i);
                if (prime)
                {
                    Console.WriteLine(i + " is a prime number");
                }
                else
                {
                    Console.WriteLine(i);
                }

            }

            DashInsert("8675309");

            Console.ReadKey();
        }

        static void FizzBuzz(int number)
        {
            //this is a program to determine whether or not a number or a set of numbers are divisible by 5, 3, or both. 
            //if the number is divisible by 3, we'll write Buzz
            //if the number is divisible by 5, we'll write Fizz
            //if the number is divisible by both, we'll write FizzBuzz
            //if the number is divisible by neither 3 nor 5, we'll just write the number.

            if (number % 5 == 0 && number % 3 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }

        static string Yodaizer(string text)
        {
            //we are making a program that reverse words in a sentence. For example, "I love dogs" would now be "Dogs love I"

            string[] words = text.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        static void TextStats(string input)
        {
            int numberOfVowelsFound = 0;
            int numberOfSpecialCharactersFound = 0;
            int numberOfConsonantsFound = 0;
            int numberOfCharactersFound = 0;
            int numberOfWordsFound = 0;



            //making a function to run through a string and count 
            //how many vowels, characters, words, consonants, and special characters
            //are found

            for (int i = 0; i < input.Length; i++)
            {
                string letter = input[i].ToString();
                if ("aeiou".Contains(letter))
                {
                    numberOfVowelsFound = numberOfVowelsFound++;
                }


                string specChar = input[i].ToString();
                if (specChar == " " || specChar == "." || specChar == "?")
                {
                    numberOfSpecialCharactersFound = numberOfSpecialCharactersFound++;
                }


                string someConsonant = input[i].ToString();
                if ("bcdfghjklmnpqrstvwxy".Contains(someConsonant))
                {
                    numberOfConsonantsFound = numberOfSpecialCharactersFound++;
                }


                string aChar = input[i].ToString();
                if (aChar == letter || aChar == someConsonant || aChar == specChar)
                {
                    numberOfCharactersFound = numberOfCharactersFound++;

                }

                string someWord = input[i].ToString();
                if (someWord == letter && someWord == someConsonant)
                {
                    numberOfWordsFound = numberOfWordsFound++;
                }


            }

        }









        /// <summary>
        /// We are using this to find prime numbers
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>


        static bool IsPrime(int number)
        {
            if ((number & 1) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //for this one i am making a function that will allow
        //the user to insert a dash between two consecutive numbers

        static void DashInsert(string number)
        {
            string oddNum = "number.ToString()";
            int value;
            int.TryParse(oddNum, out value);
            Console.WriteLine(oddNum + oddNum + "-");









        }
    }

}
