/*
Name: Leonardo Jose Ambrosio
ID: 200657215
Date: Jan/27/2026
Assignment 1 - COMP 1030 Programming Fundamentals
*/

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

        Console.WriteLine("Select the flooring type:");
        Console.WriteLine($"A){hardwood} - ${hardwoodPrice} per sq. ft.\r\nB){greeceWhite} - ${greeceWhitePrice} per sq. ft.\r\nC){grayBamboo} - ${grayBambooPrice} per sq. ft.");

        //Enter a valid option
        Console.Write("Enter your choice: ");
        string flooringChoice = Console.ReadLine();
        flooringChoice = flooringChoice.Trim().ToUpper();


        if (flooringChoice == "" || !"ABC".Contains(flooringChoice))
        {
            Console.WriteLine("You entered an invalid value. Unfortunately, we can't proceed.");
        }
        else
        {
            //Enter length and bool to lengthParsable
            Console.Write("Enter length (only one decimal point. Additional points will be rounded): ");
            string lengthString = Console.ReadLine();
            double lengthNumber;
            bool lengthParsable = double.TryParse(lengthString, out lengthNumber);


            //Enter width and bool to widthParsable
            Console.Write("Enter width (only one decimal point. Additional points will be rounded): ");
            string widthString = Console.ReadLine();
            double widthNumber;
            bool widthParsable = double.TryParse(widthString, out widthNumber);

 

            //conditions (if)

            if (!lengthParsable || !widthParsable)
            {
                Console.WriteLine("You entered an invalid value. Unfortunately, we can't proceed.");
            }
            else
            {

                //converting String (lengthString) to Double(lengthNumber)
                lengthNumber = Convert.ToDouble(lengthString);
                lengthNumber = Math.Round(lengthNumber, 1);
                
                //converting String (widthString) to Double(widthNumber)
                widthNumber = Convert.ToDouble(widthString);
                widthNumber = Math.Round(widthNumber, 1);
                

                //calculating area
                double area = lengthNumber * widthNumber;
                area = Math.Round(area, 1);
                                

                //Variables to receive the result to manipulate the receipt
                string flooringType = "";
                double flooringPrice = 0;
                bool validOption = false;
                double subTotal = 0;

                //Option A
                if (flooringChoice == "A")
                {
                    validOption = true;

                    flooringType = hardwood;
                    flooringPrice = hardwoodPrice;
                    
                    
                }
                //Option B
                else if (flooringChoice == "B")
                {
                    validOption = true;

                    flooringType = greeceWhite;
                    flooringPrice = greeceWhitePrice;
                    

                }
                //Option C
                else if (flooringChoice == "C")
                {
                    validOption = true;

                    flooringType = grayBamboo;
                    flooringPrice = grayBambooPrice;
                    

                }

                //Final Output
                Console.WriteLine($"\n\nOption {flooringChoice} - {flooringType} - ${flooringPrice} sq. ft.");
                Console.WriteLine($"Length ot the Floor: {lengthNumber} ft.");
                Console.WriteLine($"Width of the Floor: {widthNumber} ft.");
                Console.WriteLine($"Area of the Floor: {area} sq. ft.");
                
                subTotal = area * flooringPrice;
                Console.WriteLine($"TOTAL: ${subTotal:0.##}");

                //Receipt area
                if (validOption)
                    {
                    int receiptWidth = 60;
                    string dotLeader = new string('.', receiptWidth);
                    
                    int receiptDash = 60;
                    string dashLeader = new string('-', receiptDash);
                    
                    string flooringPriceReceipt = Convert.ToString(flooringPrice);
                    string areaReceipt = Convert.ToString(area);
                    int dotLeaderItem = flooringType.Length + flooringPriceReceipt.Length + areaReceipt.Length + 12;
                    string dotItemLine = dotLeader.Remove(0,dotLeaderItem);

                    //subTotal = area * flooringPrice;
                    double tax = subTotal * .13;
                    double total = subTotal * 1.13;

                    //print of Receipt
                    Console.WriteLine("\n\n\r### RECEIPT ###");
                    Console.WriteLine(dotLeader);
                    Console.WriteLine($"ITEM{dotItemLine}.........PRICE X AREA");
                    Console.WriteLine($"{flooringType}{dotItemLine}${flooringPrice} X {area} sq. ft.");
                    
                    Console.WriteLine(dashLeader);

                    Console.WriteLine($"SUBTOTAL                                            ${subTotal:0.00}");
                    Console.WriteLine($"TAX                                                 ${tax:0.00}");
                    Console.WriteLine(dashLeader);
                    Console.WriteLine($"TOTAL                                               ${total:0.00}");

                }
            }



        }

    }
}