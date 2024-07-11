namespace lab1;
// Write, Edit and Run your C# code using C# Online Compiler
public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Write a C# program that checks if a number entered by the user is positive, negative
        System.Console.Write(
            "\t\t-- Problem 1 --\n" +   
            "Enter the number : "
        );
        int num1 = int.Parse(System.Console.ReadLine());
        if(num1 > 0)
            System.Console.WriteLine("number is positive");
        else
            System.Console.WriteLine("number is negative");
            
            
        System.Console.WriteLine("*********************************");
        
        
        // Write a C# program that checks if a number entered by the user is even or odd
        System.Console.Write(
            "\t\t-- Problem 2 --\n" +   
            "Enter the number : "
        );
        
        int num2 = int.Parse(System.Console.ReadLine());
        if(num2 % 2 == 0)
            System.Console.WriteLine("number is even");
        else
            System.Console.WriteLine("number is odd");
        
        
        System.Console.WriteLine("*********************************");
        
        
        
        
        
        // Write a C# program that checks if a rectangle with given length and width is a square.
        System.Console.Write(
            "\t\t-- Problem3 --\n" +
            "Enter the length and width respectively : "
        );
        
        string [] tokens = System.Console.ReadLine().Split();
        
        int width = int.Parse(tokens[0]);
        int length = int.Parse(tokens[1]);
        
        if(width == length)
            System.Console.WriteLine("Square!");
        else
            System.Console.WriteLine("Rectangle");
        
    }
}