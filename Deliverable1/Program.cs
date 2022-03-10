using System;

namespace Deliverable1
{
    class Program
    {
        private readonly static double slicesPerLoaf = 28;
        private readonly static double tbspPerJarOfPeanutButter = 32;
        private readonly static double tspPerJarOfJelly = 48;
   
        static void Main(string[] args)

        {       //starting do while loop to restart program should user choose to do so.

            bool userRunAgain = true;
            do
            {

                //asking user for input

                Console.WriteLine("How many people are we making PB&J sandwiches for?");
                int hungryPeople = Int32.Parse(Console.ReadLine());

                double totalSlicesNeeded = hungryPeople * 2;
                double totalPeanutButterTbspNeeded = hungryPeople * 2;
                double totalJellyTspNeeded = hungryPeople * 4;
                double totalLoavesNeeded = Math.Ceiling(totalSlicesNeeded / slicesPerLoaf);
                double totalJarsOfPeanutButterNeeded = Math.Ceiling(totalPeanutButterTbspNeeded / tbspPerJarOfPeanutButter);
                double totalJarsOfJellyNeeded = Math.Ceiling(totalJellyTspNeeded / tspPerJarOfJelly);
                 

                //printing ingregients required

                Console.WriteLine();
                Console.WriteLine("You need:");
                Console.WriteLine();
                Console.WriteLine($"{totalSlicesNeeded} slices of bread.");
                Console.WriteLine($"{totalPeanutButterTbspNeeded} tablespoons of peanut butter.");
                Console.WriteLine($"{totalJellyTspNeeded} teaspoons of jelly.");

                //printing shopping list

                Console.WriteLine();
                Console.WriteLine("Which is:");
                Console.WriteLine();

                // conditionals to account for singular or plural

                if (totalLoavesNeeded <= 1)
                {
                    Console.WriteLine($"{totalLoavesNeeded} loaf of bread.");
                }
                else
                {
                    Console.WriteLine($"{totalLoavesNeeded} loaves of bread.");
                }

                if (totalJarsOfPeanutButterNeeded <= 1)
                {
                    Console.WriteLine($"{totalJarsOfPeanutButterNeeded} jar of peanut butter.");
                }
                else
                {
                    Console.WriteLine($"{totalJarsOfPeanutButterNeeded} jars of peanut butter.");
                }
                if (totalJarsOfJellyNeeded <= 1)
                {
                    Console.WriteLine($"{totalJarsOfJellyNeeded} jar of jelly.");
                }
                else
                {
                    Console.WriteLine($"{totalJarsOfJellyNeeded} jars of jelly.");
                }

                //would you like to continue?

                Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
                string userResponse = Console.ReadLine();
                if (userResponse != "y" && userResponse != "yes")
                {
                    userRunAgain = false;
                }
                
                
            } while (userRunAgain == true);

                 // program end after loop escape

             Console.WriteLine("Goodbye");
        }
    }
}
