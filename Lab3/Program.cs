/*
Name: Leonardo Jose Ambrosio
ID: 200657215
Date: Jan/19/2026
Lab 3 - COMP 1030 Programming Fundamentals
*/

using System;
public class Program
{
    public static void Main()
    {
        // Lab 3 - COMP 1030 Programming Fundamentals

        // STEP 1: Determine the radius of each of the planets of the solar system (in kilometres) and declare a variable for each using an appropriate real number type

        //Variables - Planets Radius
        //Site with the values - https://www.wolframalpha.com/input?i=planets+radius
        double mercuryRadius = 2440.0; //Km
        double venusRadius = 6050.0; //Km
        double earthRadius = 6371.009; //Km
        double marsRadius = 3390; //Km
        double jupterRadius = 69950.0; //Km
        double saturnRadius = 58300.0; //Km
        double uranusRadius = 25360.0; //Km
        double neptuneRadius = 24600.0; //Km

        // STEP 2: For each of the above variables, declare a new variable to hold the surface area using an appropriate real number type
        //Variables to hold the surface area - step 2 complete
        double mercurySurfArea;
        double venusSurfArea;
        double earthSurfArea;
        double marsSurfArea;
        double jupterSurfArea;
        double saturnSurfArea;
        double uranusSurfArea;
        double neptuneSurfArea;


        /* STEP 3: Set each of the above variables declared in STEP 2 to the surface area using an expression
        * (Hint: The formula for the surface area of a sphere is A=4πr2 (use Math.PI instead of π)
        */
        mercurySurfArea = 4 * Math.PI * Math.Pow(mercuryRadius,2);


        // STEP 4: Output a friendly sentence to the console stating the surface area of each of the planets using Console.Write()
        Console.WriteLine($"The surface area of Mercury is ${String.Format("{0:0.##}", mercurySurfArea)}.");
    }
}