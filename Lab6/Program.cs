using System;

public class Program{

    public static void Main(string[] args) {

        // STEP 1: Declare a new array (of type string), and initialize it with anywhere from 7 to 9 different ice cream flavors;
        string[] flavors = new string[7];
        flavors = new string[] {"Chocolate", "Strawberry", "Raspberry", "Blackberry", "Banana", "Mango", "Lime"};

        // STEP 2: Create a variable to contain the Length property of the array you created in STEP 1
        int flavorsLength = flavors.Length;

        // STEP 3: Output a simple sentence to the Console indicating to the user that you are about to list all the ice cream flavors available at your stand using a FOR() loop
        Console.WriteLine($"See bellow the ice cream flavors available:");

        // STEP 4: Build a FOR() loop to iterate through the array you created in STEP 1, using the variable you created in STEP 2 to control how many times the loop repeats
        for (int i = 0; i < flavorsLength; i++)
        {
        // STEP 5: Inside the FOR() loop, output each element of the array to the Console
            Console.WriteLine(flavors[i]);
        }
        
        // STEP 6: Output a simple sentence to the Console indicating to the user that you are about to list all the ice cream flavors available at your stand using a FOREACH() loop
        
        // STEP 7: Construct a FOREACH() loop that also outputs all of the elements of the same array
        // STEP 8: Inside the FOREACH() loop, output each element of the array to the Console



    }



    }