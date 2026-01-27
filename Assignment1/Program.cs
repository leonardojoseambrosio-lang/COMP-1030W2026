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
        Console.WriteLine(flooringChoice);

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

        if (lengthParsable && widthParsable && flooringChoice != "") {

            //converting String (lengthString) to Double(lengthNumber)
            lengthNumber = Convert.ToDouble(lengthString);
            lengthNumber = Math.Round(lengthNumber, 1);
            Console.WriteLine($"Length: {lengthNumber}");
            //converting String (widthString) to Double(widthNumber)
            widthNumber = Convert.ToDouble(widthString);
            widthNumber = Math.Round(widthNumber, 1);
            Console.WriteLine($"Width: {widthNumber}");

            //calculating area
            double area = lengthNumber * widthNumber;
            area = Math.Round(area, 1);
            Console.WriteLine($"Flooring area: {area}");
            Console.WriteLine($"The flooring area is: {area} sq. ft.");

            //Option A
            if (flooringChoice == "A")
            {
                string flooringType = hardwood;
                double flooringPrice = hardwoodPrice;
                Console.WriteLine($"Option A - {flooringType} - ${flooringPrice} sq. ft.");
                double subTotal = area * flooringPrice;
                Console.WriteLine($"SUBTOTAL is: ${subTotal:0.##}");
            }
            //Option B
            else if (flooringChoice == "B")
            {
                string flooringType = greeceWhite;
                double flooringPrice = greeceWhitePrice;
                Console.WriteLine($"Option B - {flooringType} - ${flooringPrice} sq. ft.");
                double subTotal = area * flooringPrice;
                Console.WriteLine($"SUBTOTAL is: ${subTotal:0.##}");
            }
            //Option C
            else if (flooringChoice == "C")
            {
                string flooringType = grayBamboo;
                double flooringPrice = grayBambooPrice;
                Console.WriteLine($"Option C - {flooringType} - ${flooringPrice} sq. ft.");
                double subTotal = area * flooringPrice;
                Console.WriteLine($"SUBTOTAL is: ${subTotal:0.##}");
            }
            //Invalid option
            else
            {
                Console.WriteLine("You did not select a valid option.");
            }


        }
        else{
            Console.WriteLine("You enter an invalid value. Unfortunatelly we can't procced.");
        }

    }
}