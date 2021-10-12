using System;

public class HelloWord
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Hello World");

        string fname, lname;

        Console.Write("enter your first name: ");
        fname = Console.ReadLine();

        Console.Write("enter your lasts name: ");
        lname = Console.ReadLine();

        Console.Write("your full name is " +fname+ " " +lname);
    }
}