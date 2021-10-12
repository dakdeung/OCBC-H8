using System;

public class nomor6
{
    public static void Main()
    {
        string word="",reverse="";
        Console.Write("Masukan Kalimat : ");
        word = Console.ReadLine();
        int i = word.Length - 1;
        while(i>=0)  
        {
            reverse += word[i];
            i--;
        }
        Console.WriteLine($"Reverse : {reverse}");
    }
}