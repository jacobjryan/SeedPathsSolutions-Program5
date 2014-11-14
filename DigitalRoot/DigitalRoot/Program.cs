using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DigitalRootWithRecursion("86753099"));
            Console.WriteLine(DigitalRootWithAWhileLoop("867530999999193491234801293581029385109235"));
            Console.ReadKey();
        }

        static int DigitalRootWithRecursion(string rootThis)
        {
            if (int.Parse(rootThis) < 10)
            {
                //its only 1 digit, return the digitalRoot
                return int.Parse(rootThis); 
            }
            else
            {
                //its more than 1 digit
                return DigitalRootWithRecursion(rootThis.Sum(x => int.Parse(x.ToString())).ToString());
            }
        }

        static int DigitalRootWithAWhileLoop(string rootThis)
        {
            //check to make sure its a number
            if (rootThis.All(x => char.IsNumber(x)))
            {
                //its true, each character was a number
                while (rootThis.Length > 1)
                {
                    //rootThis is greater than 1 digit
                    //sum all the numbers
                    int total = 0;
                    foreach (char digit in rootThis)
                    {
                        total += int.Parse(digit.ToString());
                    }
                    //place our new total as the rootThis input
                    rootThis = total.ToString();
                }
                //completed the loop, only has 1 digit
                // return rootThis as a number
                return int.Parse(rootThis);
            }
            else 
            {
                //false, not every character was a number
                return -1;
            }
        }
    }
}
