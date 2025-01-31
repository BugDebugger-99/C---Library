using System;
using Evennumbers;
using NaturalSeason;
using TriangleStars;
using List;
public class Program
{
    public static void Main()
    {

        while (true) //! Infinite loop
        {
            Console.Clear();
            Console.WriteLine("Choose a program to run:");
            Console.WriteLine("1. Even Numbers 100-400");
            Console.WriteLine("2. Season Finder");
            Console.WriteLine("3. List Handler");
            Console.WriteLine("4. Stars Printing");
            Console.Write("Enter a number (1-4) or 0 to exit: ");

            string input = Console.ReadLine();

            if (input == "0")
            {
                Console.Clear();
                break;
            }

            int choice;
            if (int.TryParse(input, out choice) && choice >= 1 && choice <= 4)
            {

                switch (choice)
                {
                    case 1:
                        EvenNumbers.Calculating();
                        break;
                    case 2:
                        SeasonFinder.DetermineSeason();
                        break;
                    case 3:
                        ListHandler.ProcessList();
                        break;
                    case 4:
                        Stars.StarsPrinting();
                        break;
                }

                while (true)
                {
                    Console.WriteLine("Do you want to run another program? (yes/no)");
                    string again = Console.ReadLine().ToLower();

                    if (again == "yes")
                    {
                        break;
                    }
                    else if (again == "no")
                    {
                        Console.Clear();
                        Console.WriteLine("Exiting program...");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input... please enter 'yes' or 'no'.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input, please enter a number between 1 and 4.");
            }
        }

        Console.WriteLine("Exiting program...");
    }

}





