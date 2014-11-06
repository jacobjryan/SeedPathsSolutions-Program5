using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupGenerator
{
    class Program
    {
        static List<string> theClass = new List<string>() {"Jake", "Eric", "Reid", "Jackie", "Andrea", 
                "Dustin", "Zachary", "Lauren", "Kaipo", "Brandon", "Aiko", "Dave", "Bayram", 
                "Edgar", "Chris", "Josh", "Chase", "Nick", "Jackson"};


        static void Main(string[] args)
        {
            //PickGroups(5, 20);


            //PickGroups3000(3, theClass);
            //PickGroups3000(4, theClass);
            //PickGroups3000(5, theClass);
            //PickGroups3000(6, theClass);
            //PickGroups3000(7, theClass);


            PickGroupsBySize(3, theClass);
            PickGroupsBySize(3, theClass);
            PickGroupsBySize(3, theClass);
            PickGroupsBySize(3, theClass);
            PickGroupsBySize(3, theClass);
            //PickGroupsBySize(2, theClass);
            //PickGroupsBySize(2, theClass);
            //PickGroupsBySize(2, theClass);
            //PickGroupsBySize(2, theClass);
            //PickGroupsBySize(2, theClass);
            //PickGroupsBySize(2, theClass);
            //PickGroupsBySize(2, theClass);
            //PickGroupsBySize(2, theClass);
            //PickGroupsBySize(2, theClass);
            //PickGroupsBySize(2, theClass);
            //PickGroupsBySize(4, theClass);
            //PickGroupsBySize(5, theClass);
            //PickGroupsBySize(6, theClass);
            //PickGroupsBySize(7, theClass);

            Console.ReadKey();

        }


        //First draft -- students are represented by integers
        static void PickGroups(int numberOfGroups, int sizeOfClass)
        {

            Random randMcNally = new Random();
            List<int> listOfPeople = new List<int>();

            //each group is represented by a string which will be printed to the console
            List<string> listOfGroups = new List<string>();
            int groupCounter = 0;

            //create a list of students
            for (int i = 0; i < sizeOfClass; i++)
            {
                listOfPeople.Add(i);
            }

            //initialize each group string, starting with its name
            for (int i = 0; i < numberOfGroups; i++)
            {
                listOfGroups.Add("Group " + (i + 1) + ": ");
            }

            //cycle through the groups, picking one student at a time to add to the current group and removing that student from the list
            while (listOfPeople.Count() > 0)
            {
                int randomPerson = randMcNally.Next(0, listOfPeople.Count());
                listOfGroups[groupCounter] += listOfPeople[randomPerson] + ", ";
                listOfPeople.RemoveAt(randomPerson);
                groupCounter = (groupCounter + 1) % numberOfGroups;
            }


            //Print all the groups, removing the final ", "
            foreach (string nextGroup in listOfGroups)
            {
                Console.WriteLine(nextGroup.Substring(0, nextGroup.Length - 2));
            }
            Console.WriteLine();
        }

        /// <summary>
        /// This improves on the first by accepting a list of names as an argument
        /// </summary>
        /// <param name="numberOfGroups"></param>
        /// <param name="theClassmates"></param>
        static void PickGroups3000(int numberOfGroups, List<string> theClassmatesInput)
        {
            Console.WriteLine("Creating " + numberOfGroups + " groups.");

            //clone the list so we can call the function multiple times without emptying it
            List<string> theClassmates = new List<string>(theClassmatesInput);
            
            //In this version, the groups are represented by lists of strings, not strings.
            //Create a list of lists of names and populate it with empty lists
            List<List<string>> listOfGroups = new List<List<string>>();
            for (int i = 0; i < numberOfGroups; i++)
            {
                listOfGroups.Add(new List<string>());
            }

            Random randMcNally = new Random();

            int groupCounter = 0;

            //Cycle through the groups, randomly picking a student and moving them from the list of students to the group
            while (theClassmates.Count() > 0)
            {
                int randomPerson = randMcNally.Next(0, theClassmates.Count());
                listOfGroups[groupCounter].Add(theClassmates[randomPerson]);
                theClassmates.RemoveAt(randomPerson);
                groupCounter = (groupCounter + 1) % numberOfGroups;
            }

            //Printing the output
            for (int i = 0; i < listOfGroups.Count(); i++)
            {
                string printOut = "Group " + (i + 1) + ": ";
                foreach (string student in listOfGroups[i])
                {
                    printOut += student + ", ";
                }
                Console.WriteLine(printOut.Substring(0, printOut.Length - 2));
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Picks groups given a size and a list of names(strings)
        /// </summary>
        /// <param name="sizeOfGroups"></param>
        /// <param name="theClassmates"></param>
        static void PickGroupsBySize(int sizeOfGroups, List<string> theClassmatesInput)
        {
            List<string> theClassmates = new List<string>(theClassmatesInput);
            int sizeOfClass = theClassmates.Count();
            int numberOfGroups = sizeOfClass / sizeOfGroups;

            //This checks to see if the next higher number of groups would yield more groups 
            //with the desired size. If so, it increments the number.
            if (sizeOfClass % sizeOfGroups > sizeOfGroups / 2)
            {
                numberOfGroups++;
                Console.WriteLine("Creating groups of " + (sizeOfGroups - 1) + " and " + sizeOfGroups + " students.");
            }
            else
            {
                Console.WriteLine("Creating groups of " + sizeOfGroups + " and " + (sizeOfGroups + 1) + " students.");

            }


            List<List<string>> listOfGroups = new List<List<string>>();
            for (int i = 0; i < numberOfGroups; i++)
            {
                listOfGroups.Add(new List<string>());
            }

            Random randMcNally = new Random();

            int groupCounter = 0;

            while (theClassmates.Count() > 0)
            {
                int randomPerson = randMcNally.Next(0, theClassmates.Count());
                listOfGroups[groupCounter].Add(theClassmates[randomPerson]);
                theClassmates.RemoveAt(randomPerson);
                groupCounter = (groupCounter + 1) % numberOfGroups;
            }

            for (int i = 0; i < listOfGroups.Count(); i++)
            {



                Console.WriteLine(string.Join(", ", listOfGroups[i]));



                //    string printOut = "Group " + (i + 1) + ": ";
                //    foreach (string student in listOfGroups[i])
                //    {
                //        printOut += student + ", ";
                //    }
                //    Console.WriteLine(printOut.Substring(0, printOut.Length - 2));
            }
            Console.WriteLine();
        }

    }
}