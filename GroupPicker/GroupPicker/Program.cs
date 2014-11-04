using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1_flipmaniaHW
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        //Create a function called FlipCoins that takes an integer called "numberOfFlips" 
            static void FlipCoins(int numberOfFlips)
             {
           //now we are inside of our function
           //declare counters for the numberOfHeads, and the numberOfTails

            //do a for loop because we'll be looping x number of times
            
            int numberOfHeadsCounter = 0;
            int numberOfTailsCounter = 0;
             //both are zero because we haven't flipped the coin yet
            //create a loop that will repeat as many times 
            //as indicated by the "numberOfFlips argument
                //name your random number gen to flip a coin
            Random coinFlip = new Random();
            for(int i = 0; i < numberOfFlips; i = i + 1)
           
                //declare a new instance of the Random object (for flipping)
                {
                //
                //now we are actually flipping our coin (which we are calling "coin" but it can be named anything)
                int coin = coinFlip.Next(0,2);
                if(coin == 1)
                {
                    //yay we got a heads
                    numberOfHeadsCounter = numberOfHeadsCounter+1;
                    //or numberOfHeadsCounter++;
                    //or numberOfHeadsCounter +=1;
                }
                        else
                {
                            //got a tails sweet
                            numberOfTailsCounter = numberOfTailsCounter+1;
                        }
                    }
                //output AFTER the loop completes
                Console.WriteLine("We flipped a coin " + numberOfFlips + " times.");
                Console.WriteLine("Number of heads: " + numberOfHeadsCounter);
                Console.WriteLine("Number of Tails: "+ numberOfTailsCounter);
                
                }

             
        
        //create a function called FlipForHeads which takes an integer called numberOfHeads.
        //using a while loop here because we don't know how many times it'll take to flip x amount of heads
            static void FlipForHeads(int numberOfHeads)
            {
                //declare counters for the numberOfHeadsFlipped and totalFlips
                //Also declare a new instance of Random object for flipping
                int numberOfHeadsFound = 0;
                int totalFlips = 0;
                Random coinFlip = new Random();
                //great now lets flip some coins
                while(numberOfHeads != numberOfHeads)
                {
                    int coinFlipResult = coinFlip.Next(0,2);
                    //was it a heads?
                    if(coinFlipResult == 0)
                        numberOfHeadsFound ++;
                      totalFlips++;
                }
    //we got a heads
                
//output
//just a different way to write it (use of the commas finds and replaces it) 
Console.WriteLine("It took us {0} flips to get {1} heads", totalFlips, numberOfHeads);
  
//increment the number found
                //create a while loop that loops until the numberOfHeadsFlipped equals the numberOfHeads argument
int i = numberOfHeadsFound;
                while(i == numberOfHeads);
                //inside your loop, flip a coin using the Random object's.Next() method
                int randomNumber = coinFlip.Next(totalFlips);
                {
                    //after the loop completes, write to console
                    //"we are flipping a coin until we find <numberOfHeadsFlipped> heads"
                    //"it took <totalFlips> to find <numberOfHeads> heads"
                    Console.WriteLine("We are flipping a coin until we find " + numberOfHeadsFound + "heads");
                    Console.WriteLine("It took " + totalFlips + "to find " + numberOfHeads + " heads");
                }
                {
                    Console.ReadKey();
                }
                FlipCoins(10000);
                FlipForHeads(10000);
                {
                    Console.ReadKey();
                }
                }
       

            }
    
      
    }

