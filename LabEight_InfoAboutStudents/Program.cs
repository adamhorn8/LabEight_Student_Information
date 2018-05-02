using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabEight_InfoAboutStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            //Decalre all names, hometowns, and favorite foods as string arrays
            int StudentNumber;
            string[] Name = {     "Adam",     "Bob",      "Chris", "Dan",   "Evan",      "Frank",    "George", "Hank",    "Ivan",     "Jim",     "Kevin", "Lance",  "Max",       "Nick",    "Oscar", "Peter", "Quinn",  "Rick",      "Sam",     "Tommy" };
            string[] Hometown = { "Ancorage", "Budapest", "Cadiz", "Dubai", "Edinburgh", "Florence", "Geneva", "Hamburg", "Istanbul", "Jakarta", "Kyoto", "London", "Milan",     "Naples",  "Oslo",  "Paris", "Quebec", "Reykjavík", "Seville", "Tangier"};
            string[] FavFood = {  "Apple",    "Beef",     "Corn",  "Donut", "Eggs",      "Fish",     "Gravy",  "Ham",     "Ice",      "Jelly",   "Kale",  "Lemons", "Mushrooms", "Noodles", "Onion", "Pasta", "Quail",  "Rice",      "Steak",   "Tomato" };

            //Create while loop to validate student selection
            while (true)
            {
                //Ask for user input
                Console.WriteLine();
                Console.Write("Which Student would you like to know about (1-20)? ");
                string StudentNumberS = Console.ReadLine();

                //Validate input using the tryparse method
                bool StudentNumberB = int.TryParse(StudentNumberS, out StudentNumber);


                //If else statement to further validate input
                if (StudentNumberB == true)
                {
                    if ((StudentNumber >= 0 && StudentNumber < Name.Length))
                    {
                        Console.WriteLine($"Student {StudentNumber} is {Name[StudentNumber]}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("That number was not between 1-20.  Try again.");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("That was not a number.  Try again.");
                }
            }   

            //While loop to repeat information about student
            while (StudentNumber >= 0 && StudentNumber < Name.Length)
            {
                //Ask user what they would like to know
                Console.WriteLine();
                Console.WriteLine($"What would you like to know about {Name[StudentNumber]}?");
                Console.Write($"(Please type \"Hometown\" or \"Favorite Food\")  ");
                string MoreInfo = Console.ReadLine().ToLower();

                //If else to differentiate what user would like to learn
                if (MoreInfo == "hometown" || MoreInfo == "ht")
                {
                    Console.WriteLine();
                    Console.WriteLine($"{Name[StudentNumber]}'s hometown is {Hometown[StudentNumber]}");

                    //Ask if user would like to know more
                    Console.WriteLine();
                    Console.WriteLine($"Would you like to know more about {Name[StudentNumber]}?");
                    Console.Write("Please enter \"Yes\" or \"No\" ");
                    string EvenMore = Console.ReadLine().ToLower();

                    //If else statement to determine whether or not they would like to know more
                    if (EvenMore == "no" || EvenMore == "n")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Thanks!");
                        break;
                    }
                    else if (EvenMore == "yes" || EvenMore == "y")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sorry I didnt get that.");
                    }

                }//If else to differentiate what user would like to learn
                else if (MoreInfo == "favorite food" || MoreInfo == "ff")
                {
                    Console.WriteLine($"{Name[StudentNumber]}'s favorite food is {FavFood[StudentNumber]}");

                    //Ask if user would like to know more
                    Console.WriteLine();
                    Console.WriteLine($"Would you like to know more about {Name[StudentNumber]}?");
                    Console.Write("Please enter \"Yes\" or \"No\" ");
                    string EvenMore = Console.ReadLine().ToLower();

                    //If else statement to determine whether or not they would like to know more
                    if (EvenMore == "no" || EvenMore == "n")
                    {
                        Console.WriteLine();
                        Console.WriteLine("Thanks!");
                        break;
                    }
                    else if (EvenMore == "yes" || EvenMore == "y")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Sorry I didnt get that.");
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Hey sorry, I need you to type \"Hometown\" or \"Favorite Food\"");
                    Console.WriteLine("You can also type HT or FF");
                }
            }
        }
    }
}