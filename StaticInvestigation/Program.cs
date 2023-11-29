using StaticInvestigation;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {

        int i = 10;


        Console.WriteLine("Static Investigation");

        Message m = new Message { 
            Title = "Message 1", 
            Text = "This is m1" 
        };

        Message m2 = new Message();

        Console.WriteLine(Message.Count);

        // examples of static
        Console.WriteLine();

        // constants
        //Math.PI;
        //Math.E

        // functions that don't require an instance
        //Math.

        // String.Format


        // conversion functions - these are often static.
        string value = "12345";
        













    }
}