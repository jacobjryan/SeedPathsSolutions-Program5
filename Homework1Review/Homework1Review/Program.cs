using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1Review
{
    class Program
    {
        //global integer
        static int myFirstGlobalVariable = 123;
        static void Main(string[] args)
        {

            // #20
            //print out the # of letters in each item in productlist
            //"<product> has <number of letters> in it"
            List<string> productList = new List<string>() { "tennis shoes", "basketball" };

            //create a loop to go over each item
            for (int i = 0; i < productList.Count(); i = i + 1)
            {
                string aSingleProductFromTheList = productList[i];
                int numberOfLettersInTheProductName = aSingleProductFromTheList.Length;
                Console.WriteLine(aSingleProductFromTheList + " has " + numberOfLettersInTheProductName + " letters in it.");
                // the line below works just as well as the 3 lines above
                //Console.WriteLine(productList[i] + " has " + productList[i].Length + "...");
            }

      
            //#17
            //create a while loop with the condition
            // of while(myBool).  Then print the numbers
            // from 1=>10, until it reaches on that is
            // divisble by 4.  When it finds one divisible
            // by 4, then set myBool = false
            bool myBool = true;
            //create a counter to count the number
            int counter = 1;
            while (myBool)
            {
                
                Console.WriteLine(counter);
                //check to see if the number is divisible
                // by 4
                if (counter % 4 == 0)
                {
                    //it is divisible by 4
                    myBool = false;
                }
                counter = counter + 1;
            }
          
            //call the loop this function
            LoopThis(3, 33);
            LoopThis(33, 333);


            //using NewGreeting() as a parameter for 
            //Console.WriteLine, call it using "Jeff Macco"
            Console.WriteLine(NewGreeting("Jeff Macco"));

            //keep console open
            Console.ReadKey();
            //changing the value of a global variable
            myFirstGlobalVariable = 12;
            aFunction();

        }

        static void aFunction()
        {
            //change the value of the global variable
            myFirstGlobalVariable = 15;
        }

        //create a funciton called LoopThis, 
        // takes 2 int params called startNum and endNum
        // print out:
        // "I'm looping from <startNum> to <endNum>
        // print the numbers 1 per line
        static void LoopThis(int startNum, int endNum)
        {
            Console.WriteLine("I'm looping from " + startNum + " to " + endNum);
            for (int i = startNum; i <= endNum; i = i + 1)
            {
                Console.WriteLine(i);
            }
        }


        //using NewGreeting() as a parameter for 
        //Console.WriteLine, call it using "Jeff Macco"
        static string NewGreeting(string name)
        {
            return "What's going on, " + name;
        }
    }
}
