using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextPrinter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) { 
            TextPrinter("I am from the 80s.  Watch my text slowly print to the screen.  I am a robot. \nPew pew pew pew pew pew pew.", 50);
            TextPrinter("Destroy all humans.  Destroy all humans. Destroy all humans. Destroy all humans.Destroy all humans.  Destroy all humans. Destroy all humans. Destroy all humans.Destroy all humans.  Destroy all humans. Destroy all humans. Destroy all humans.Destroy all humans.  Destroy all humans. Destroy all humans. Destroy all humans.Destroy all humans.  Destroy all humans. Destroy all humans. Destroy all humans.Destroy all humans.  Destroy all humans. Destroy all humans. Destroy all humans.Destroy all humans.  Destroy all humans. Destroy all humans. Destroy all humans. This was faster.", 10);
            TextPrinter("Another line of text that prints super slowly", 250);
            }
        }

        static void TextPrinter(string textToPrint, int delayInMilliseconds)
        {
            for (int i = 0; i < textToPrint.Length; i++)
            {
                //printing a letter to the console
                Console.Write(textToPrint[i]);
                //pause for a certain amount of time
                System.Threading.Thread.Sleep(delayInMilliseconds);
            }
            Console.WriteLine();
        }
    }
}
