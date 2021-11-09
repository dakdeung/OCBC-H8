using System;

namespace dotnet2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        string fname, lname, birthday,address;
        int umur;

        Console.Write("enter your first name: ");
        fname = Console.ReadLine();

        Console.Write("enter your lasts name: ");
        lname = Console.ReadLine();

        Console.Write("enter your birthday: ");
        birthday = Console.ReadLine();

        Console.Write("enter your address: ");
        address = Console.ReadLine();

        Console.Write("enter your umur: ");
        umur = int.Parse(Console.ReadLine());

        Console.Write("your full name is " +fname+ " " +lname);

        Console.Write("your birth day is " +birthday+ "your address is " +address);

        Console.Write("your umur "+ umur);
        }
    }
}
