/*
Name: Leonardo Jose Ambrosio
ID: 200657215
Date: Mar / 23 / 2026
Lab 10 - COMP 1030 Programming Fundamentals
*/

// LAB 10
// STEP 1: Declare "Shapes" as a dependency with "using"
using Shapes;
using System.Drawing;

namespace Shapes
{
    public class Program
    {

        static void Main(string[] args)
        {
            // STEP 2: Proceed to Shapes.cs and examine the class Rectangle

            // STEP 3: Create an instance of a new Rectangle object (call it var rectangle1) and give it a height and width in integers (passed in as arguments)
            var rectangle1 = new Rectangle(10, 10);
            // STEP 4a: Get a description of the rectangle1 object by invoking (or calling) the DescribeRectangle() method and assigning it to a string type called description1
            var description1 = rectangle1.DescribeRectangle();

            // STEP 4b: Output description1 using Console.WriteLine()
            Console.WriteLine(description1);
            // STEP 4c: Draw the rectangle1 object to the console by invoking the DrawRectangle() method
            rectangle1.DrawRectangle();
            // STEP 5: Compile and run the application to see the result or to track down any errors

            // STEP 6: Create another instance of a Rectangle object (var rectangle2) and give it a different height and width in integers (as arguments)
            var rectangle2 = new Rectangle(4, 8);

            // STEP 7a: Get a description of the rectangle object by invoking (calling) the DescribeRectangle() method and assigning it to a string type called description1
            var description2 = rectangle2.DescribeRectangle();

            // STEP 7b: Output description1 using Console.WriteLine()
            Console.WriteLine(description2);
            // STEP 7c: Draw the rectangle1 object to the console by invoking the DrawRectangle() method

            // STEP 8: Compile and run the application once again to see the result
        }
    }
}