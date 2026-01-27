using System;

public class Program
{
    public static void Main(string[] args)
    {
        //assign three string variables for three different types of flooring each with a price per square foot (perhaps "Hardwood ($8.95/sq.ft.)" as an example - come up with something original, here).
        //reference price https://www.cancork.com/?msclkid=3df8d91eb99a1b1e9ba4b0665dda4503
        string hardwood = "Hardwood";
        double hardwoodPrice = 8.95;

        string greeceWhite = "Greece White";
        double greeceWhitePrice = 13.99;

        string grayBamboo = "Gray Bamboo";
        double grayBambooPrice = 6.29;

        Console.WriteLine($"{hardwood} - ${hardwoodPrice}");
        Console.WriteLine($"{greeceWhite} - ${greeceWhitePrice}");
        Console.WriteLine($"{grayBamboo} - ${grayBambooPrice}");




    }
}