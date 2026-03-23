namespace Shapes;

public class Rectangle
{
    /* PROPERTIES
    A Rectangle object will only require two properties, height and width (in characters) */
    public int Height { get; }
    public int Width { get; }

    /* CONSTRUCTOR
    When a new Rectangle object is instantiated, we will need to know (in integers) the height and width, which we will use to set the above properties */
    public Rectangle(int height, int width)
    {
        this.Height = height;
        this.Width = width;
    }

    /* METHODS
    The below functions are things that a Rectangle object can do - it can draw itself to the console, and it can return a string that describes itself
    */
    // Notice how the DrawRectangle() method does not need to return anything, so the method signature below includes the return type 'void'
    public void DrawRectangle()
    {
        // Jump to a new line on the console
        string bitmap = "\n";
        // The height of the rectangle is equal to the number of rows we need to build the bitmap image, so we can use a for() loop
        for (int i = 0; i < this.Height; i++)
        {
            // The width of the rectangle is equal to the number of columns we need for the bitmap image, so we can use another for() loop
            for (int j = 0; j < this.Width; j++)
            {
                // Add a full block square (█) to the bitmap string (a unicode box character that can be output to a string with \u2588)
                bitmap += "█";
                // If your console has trouble rendering the above box character, you can just use a "*" instead
            }
            // End of the row so we need to break to a new line for the next row of blocks
            bitmap += "\n";
        }
        // Set console to use unicode characters so it renders the above box character properly
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        // Draw the rectangle to the console
        Console.WriteLine(bitmap);
    }

    // Notice how the DescribeRectangle() method needs to return a string (which is a description of the Rectangle object), so the method signature below includes the return type 'string'


    public string DescribeRectangle()
    {
        string description;
        // Write a short sentence describing the rectangle
        description = $"This is a rectangle that is {this.Height} units high and {this.Width} units wide.";
        // Send the description of the object back to where this method was invoked
        return description;
    }
}