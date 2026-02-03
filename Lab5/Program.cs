using System;

public class Program
{
    public static void Main(string[] args)
    {
        START


 // Outer loop: iterate through rows 1 to 10
 FOR row FROM 1 TO 10 DO


     // Initialize column counter for inner loop
     col = 1


    // Inner loop: iterate through columns 1 to 10
    WHILE col <= 10 DO


        // Calculate the product of current row and column
        product = row * col


        // Format output: add extra space for single-digit numbers
        IF product< 10 THEN
            PRINT product + ",  "
        ELSE
            PRINT product + ", "
        ENDIF


        // Move to next column
        col = col + 1



    END WHILE


    // Move to the next row after finishing all columns
    PRINT NEWLINE



END FOR



END
    }
}