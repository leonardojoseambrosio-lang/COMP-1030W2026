using System;

public class Program
{
    public static void Main(string[] args)
    {
        /* Write a short program that gets the current hour and day of the week. If it is a weekday, and the hour is 6am or later, output a message that indicates it is time to wake up and get ready for the work day.
* If it is Saturday or Sunday, and it is 9am or later, output a message to the console indicating that is the weekend and it is time to get up and enjoy the day. If neither of the previous two situations are
* the case, then output a message to the console that indicates that it is not yet time to get out of bed
*/

        // STEP 1: Read the below code - we have created a variable called localDate (which is data type DateTime) - this stores the current date and time for your computer
        DateTime localDate = DateTime.Now;

        // STEP 2a: Have a look at the below code - we have created two variables (of data type string) that contain the hour (2:00pm would be 14), and the day of the week (Tuesday for example)
        string day = localDate.ToString("dddd");
        string hourString = localDate.ToString("%H");

        // STEP 2b: Examine the below line of code - we need to convert the variable hour to an integer (so we can use relational operators later)
        int hour = Int32.Parse(hourString);

        // STEP 3: Create an 'if' condition to check whether it is the weekend (hint: you might consider the equality operator and the OR logical operator here)

        if (day == "Saturday" || day == "Sunday")
        {
            Console.WriteLine($"Today is weekend!");
            // STEP 5a: It is either Saturday or Sunday, so now we need an if/else condition to see whether it is time to wake up or not
            if (hour >= 9)
            {
                Console.WriteLine($"It's {hourString}. It's time to wake up and enjoy your day!");
            }
            else
            {
                Console.WriteLine($"It's {hourString}. It is not yet time to get out of bed...");
            }
        }
        else
        {
            Console.WriteLine("Today is a weekday.");
            Console.WriteLine($"Hour: {hour}");
        }


        

        // STEP 5b: It is 9am or later, so output a message to the console that it is the weekend and it is time to wake up and enjoy the day

        // STEP 5c: It is not yet 9am, so output a message to the console that it not yet time to get up

        // STEP 4: Create an 'else' structure here for the part of the program that deals with weekdays

        // STEP 6a: We need to create a condition that checks to see whether it is 6am or later

        // STEP 6b: It is indeed 6am or later, so output a message to the console that it is time to get up and go to work

        // STEP 6c: It is not yet 6am, so output a message to the console that it is not yet time to wake up
    }
}