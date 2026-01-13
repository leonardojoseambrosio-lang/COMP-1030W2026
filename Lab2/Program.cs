using System;
public class Program
{
    public static void Main()
    {
        // Lab 2 - COMP 1030 Programming Fundamentals

        /* STEP 1: Create string variables for each of the following:
        a) Todays weather conditions (i.e. "cloudy", "sunny", "partly-cloudy", "rainy")
        b) Possibility of precipitation (i.e. "40%" or "60%" or whatever)
        c) Wind conditions (i.e. "30 km/h with gusts to 50 km/h")
        d) Daily high temperature (i.e. "18°C")
        e) Daily low temperature (i.e. "7°C")
        f) UV index (i.e. "4 or moderate", "7 or high", or whatever)
        */

        // STEP 2: Create another string variable that assembles all of the above variables that describes today's weather, using String interpolation or simple concatenation.

        // STEP 3: Output the sentence created in STEP 2 to the console with Console.WriteLine().

        //Variables

        string weather = "sunny"; //Weather condition
        string possibPrecip = "60%"; //Possibility of preciptation
        string windConditions = "23 km/h with gusts to to 57 km/h"; //Wind conditions
        string dailyHighTemp = "32ºC"; // Daily high temperature
        string dailyLowTemp = "28ºC"; //Daily low temperature
        string uvIndex = "7 or high"; //UV index


        //Assembling all the variables
        string assemblingAll = $"Today's weather is {weather}";

        //Output the sentence (test)
        Console.WriteLine(assemblingAll);


    }
}