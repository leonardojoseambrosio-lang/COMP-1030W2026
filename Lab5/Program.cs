using System;
using System.Net.Http.Headers;

public class Program
{
    public static void Main(string[] args)
    {



        // Outer loop: iterate through rows 1 to 10
        //FOR row FROM 1 TO 10 DO
        // Outer loop: iterate through rows 1 to 10
        
        for (int x = 1; x <= 10; x++)
        {
            int y = 1;

            // Initialize column counter for inner loop


            // Inner loop: iterate through columns 1 to 10
            while (y <= 10)
            {

                int product = x * y;

                // Calculate the product of current row and column



                // Format output: add extra space for single-digit numbers
                if (product < 10)
                {
                    Console.Write($"{product},  ");
                }
                else
                {
                    Console.Write($"{product}, ");
                }



                y++;

               

            }


            // Move to the next row after finishing all columns
            Console.WriteLine();


        }

    }
}
      