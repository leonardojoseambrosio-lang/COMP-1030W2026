using System;
using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main()
    {
        /*
        The program generates a random target temperature, and the user tries to match it.
        All user guesses must be stored in an array or list and displayed at the end.You are using
        VSCode for this.
        Requirements
       */

        //- Generate a random temperature between 10 and 40.
        Random randomNum = new Random();
        int rnd = randomNum.Next(10, 41);//creates a random number between 10 and 40.

        //- Ask the user to guess the temperature.
        Console.WriteLine("### Welcome to the Temperature History Game ###");

        Console.WriteLine($"Random:{rnd}\nRandon -3:{rnd - 3}\nRandon +3:{rnd + 3}\n");// - check rnd values (random number)

        Console.WriteLine("Enter temperature (10 - 40):");

        int[] guess = new int[10];
        int index = 0;

        //loop condition
        while (index < 10)
        {
            Console.WriteLine($"Index{index}");// - check index value
            string typeYourAnsewer = Console.ReadLine();

            //Provide feedback:

            if (Int32.TryParse(typeYourAnsewer, out guess[index]))
            {

                guess[index] = Int32.Parse(typeYourAnsewer);

                //- Perfect
                if (guess[index] == rnd)
                {
                    Console.WriteLine("Perfect!");
                    index++;
                    break;
                }
                //- Too cold
                if (guess[index] < rnd - 3 ^ guess[index] > rnd + 3)
                {
                    Console.WriteLine("Too cold!");



                }
                //- Too warm
                else
                {
                    Console.WriteLine("Too warm!");
                }

            }
            else
            {
                Console.WriteLine("\nIt's not a number. You lose a chance");
            }


            //condition to print "Try again"
            if (index < 9)
            {
                Console.WriteLine("\nTry again a number between 10 to 40:");
            }

            //index increment
            index++;
        }
        //Store every guess in an array or list.
        //After the game ends, display all guesses.
        Console.WriteLine("\nYour Guess:");

        for (int i = 0; i < index; i++)
        {

            if (i  >= index - 1)
            {
                Console.Write($"{guess[i]}.");

            }
            else
            {
                Console.Write($"{guess[i]}, ");
            }
    
        }
    }
}