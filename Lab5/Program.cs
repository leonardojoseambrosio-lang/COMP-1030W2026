using System;

public class Program
{
    public static void Main(string[] args)
    {
     


 // Outer loop: iterate through rows 1 to 10
 //FOR row FROM 1 TO 10 DO
 for (int x = 1; x <= 10; x++)
     {

       int y = 1;
       int product = x * y;
       int verify = x * 10;
            Console.Write($"{product} ,");

            if (product == 10)
            {
                Console.WriteLine("\nTest");
            }
          
        
      
        
      }



    }

}