/*
Name: Leonardo Jose Ambrosio
ID: 200657215
Date: Mar/10/2026
Lab 8 - COMP 1030 Programming Fundamentals
*/

// STEP 1: Include the "System" library as a dependency
using System;
// STEP 2: Create a class for the C# Console App program itself
class Program
{
    /* STEP 4: Create a method called "Alert" - there are 4 components:
    a) method modifier - declares whether the method is available outside of its containing class
    b) (adding "static" means that the method can be called without creating an instance of the object class)
    c) return type - this indicates what sort of data will be returned by the method when called, with "void" indicating it will return nothing (start with "void")
    d) method identifier - the name given to the method, which should describe succinctly what its purpose is
    e) parameters - zero, one or more data required for the method to perform its task (we will begin with empty parentheses) */
    //public static void Alert()

    // STEP 7: Add a single parameter to the Alert() method - type string (for a message)
    //public static string Alert(string message)

    // STEP 10: Add two more parameters to the method - alert level (type int), and whether a sound should be played (type bool)
    public static string Alert(int level, string message, bool sound, bool date)//fourth parameter added - date
    {
        // STEP 5: Write a message to the console with a message for the user
        // Console.WriteLine("This is a serious alert!");

        // STEP 8: Write a message to the console that incorporates the passed in argument to the message parameter
        // Console.WriteLine($"Alert: {message}!");

        // STEP 11: Write a message to the console that incorporates the level, and the message
        // Console.WriteLine($"Alert level {level}: {message}!");

        // STEP 12: Create a condition where if sound is true, we make the console beep (Windows only)

        //Condition for print date
        string showDate = ""; //string to receive the value of the date.

        if (date)
        {

            showDate = $"Date: {DateTime.Now.ToString("MMM d, yyyy")}"; //formart Mount day, Year

        }


        
        if (sound)
        {
            Console.Beep(200, 250);
        }

        // STEP 14: Do something interesting with the "level" parameter, by changing the color of the console (1 = green, 2 = yellow, 3 = red, otherwise black) using a switch() statement
        string howSerious;

        switch (level)
        {
            case 1:
                Console.BackgroundColor = ConsoleColor.Green;
                howSerious = "Not really anything to fret about.";
                break;

            case 2:
                Console.BackgroundColor = ConsoleColor.Yellow;
                howSerious = "You should be worried.";
                break;

            case 3:
                Console.BackgroundColor = ConsoleColor.Red;
                howSerious = "It is time to freak out!";
                break;

            default:
                Console.BackgroundColor = ConsoleColor.Black;
                howSerious = "Alert level is not set or is not valid.";
                break;
        }
        Console.Clear();

        // STEP 15: Return something from the method - add a "howSerious" string variable above the switch() statement above, and set the value to various messages, escalating in seriousness

        // STEP 16a: Create a string variable (often called result) that assembles a string including the alert level, the message argument, and the new howSerious variable
        string result = $"Alert level {level}. {message}. {howSerious} {showDate}"; //Adding variable to show date in result (showDate)
        // STEP 16b: Return the result string back to the program
        return result;
    }

    // STEP 3: Create the method for the entry point for the C# program itself (https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/main-command-line)
    static void Main()
    {
        // STEP 6: Invoke the method from inside the program Main()
        //Alert();

        // STEP 9: Invoke the method again, but pass in an argument for the message parameter
        //Alert("We are not fooling around, here. You should be very concerned.");

        // STEP 13a: Invoke the method, passing in all three required arguments (note that the arguments need to be in the same order as the method parameters)
        //Alert(2, "Drop everything - this is a critical issue", true);
        // STEP 13b: Change the order of the arguments in the above method call
        // STEP 13c: Named parameters avoids the issue of possibly passing method arguments in the wrong order

        string alertMessage = Alert(message: "We are all out of coffee", sound: true, level: 1, date: true); //Variable date added to Alert() method.
        Console.WriteLine(alertMessage);
    }
}