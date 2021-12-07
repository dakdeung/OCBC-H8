using System;

public class data3
{
    public static void Main()
    {
        char[] charray = {'1', ' ', 's', 't','r', 'i','n', 'g', '.'};
        string str1 = new string(charray);
        string str2 = "String lain.";

        Console.Write(str1);
        Console.Write(str2);
    }
}