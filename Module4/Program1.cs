using System;
using System.ComponentModel.Design;

public class Program1
{
    public static void Run()
    {
        Console.WriteLine("Second program");

        /* STEP 1: List out the ride choices
        A) Casual Carousel (no age limit)
        B) Bumpy Boats (minimum 5 years)
        C) Rowdy Road Race (minimum 7 years)
        D) Tunnel of Terror (minimum 12 years / maximum 75 years) */

        Console.WriteLine("Welcome to Fantastic Fair\nWhat ride are you interested in (type A, B, C or D)?");
        Console.WriteLine("A) Casual Carousel (no age limit)\r\nB) Bumpy Boats (minimum 5 years)\r\nC) Rowdy Road Race (minimum 7 years)\r\nD) Tunnel of Terror (12-75 years)");

        // STEP 2a: Ask the user to pick a ride and store it as a string
        string rideChoice = Console.ReadLine();

        // STEP 2b: Trim any whitespace from the input, and capitalize it
        rideChoice = rideChoice.Trim().ToUpper();

        // STEP 2c: Output the guest's choice
        Console.WriteLine($"You picked {rideChoice}");

        // STEP 3a: Ask the rider how old they are and store it as a string
        Console.WriteLine("What is your age in years?");
        string riderAgeString = Console.ReadLine();

        // STEP 3b: Try to convert the input to an integer - declare a variable to contain the number
        int rideAgeNumber;

        // STEP 3c: Create a boolean variable that attempts to parse the rider's age into an integer
        bool isParsable = Int32.TryParse(riderAgeString, out rideAgeNumber);

        // STEP 3d: If the riderAgeString can be converted to an integer, and they picked a ride, then we can proceed to see what ride they chose
        if (isParsable && rideChoice != "")
        {
            // STEP 4a: They picked ride "A"...
            if (rideChoice == "A")
            {
                // STEP 4b: There are no age limits for this ride... let them know they can ride
                Console.WriteLine("There are no age limits for Casual Carousel. Enjoy your ride!");
            }
            // STEP 5a: They picked ride "B"...
            else if (rideChoice == "B")
            {
                // STEP 5b: Check to see if they are at least 5, if not tell them they cannot ride
                if (rideAgeNumber >= 5)
                    Console.WriteLine($"You are {rideAgeNumber} years old - old enough for Bumpy Boats. Have fun!");
                else
                    Console.WriteLine("You are not old enough for Bumpy Boats.");
            }
            // STEP 6a: They picked ride "C"...
            else if (rideChoice == "C")
            {
                // STEP 6b: Check to see if they are at least 7, if not let them know they cannot ride
                if (rideAgeNumber >= 7)
                    Console.WriteLine($"You are {rideAgeNumber} years old - old enough for Rowdy Road Race. Enjoy!");
                else
                    Console.WriteLine("You are not old enough for Rowdy Road Race.");
            }
            // STEP 7a: They picked ride "D"...
            else if (rideChoice == "D")
            {
                // STEP 7b: First we check if they are old enough to go on this ride
                if (rideAgeNumber >= 12)
                {
                    // STEP 7d: They are old enough, but we need to see if they are too old, now
                    if (rideAgeNumber > 75)
                    {
                        // STEP 7e: They are too old - let them know they cannot ride
                        Console.WriteLine("Sorry but you are too old to ride Tunnel of Terror.");
                    }
                    else
                    {
                        // STEP 7f: They are neither too old nor too young - they can ride!
                        Console.WriteLine("You are just the right age for Tunnel of Terror. Prepare to be afraid!");
                    }
                }
                else
                {
                    // STEP 7c: They are not old enough to ride this attraction
                    Console.WriteLine("Sorry, you are not old enough for Tunnel of Terror.");
                }
            }
            else
            {
                // STEP 3e: The park guest did not enter a valid ride - let them know they can't ride
                Console.WriteLine("Sorry, you did not choose a valid ride option.");
            }

            // STEP 8: What situation will this program not be able to deal with? 
            // (e.g., entering a negative age or non-integer input, or a ride choice outside A-D)
        }
        else
        {
            // STEP 3e: The park guest did not enter a valid age or they didn't pick a ride - let them know they can't ride
            Console.WriteLine("Invalid input. Make sure you entered a valid ride choice and your age as a number.");
        }
    }
}
