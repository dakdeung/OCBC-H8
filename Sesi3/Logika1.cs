using System;

public class Logika1
{
    public static void Main()
    {
        int nilai1, nilai2;
        Console.Write("Masukan Nilai1: ");
        nilai1 = int.Parse(Console.ReadLine());
        Console.Write("Masukan Nilai2: ");
        nilai2 = int.Parse(Console.ReadLine());
        if(nilai1 > nilai2){
            Console.WriteLine("Nilai1 lebih dari Nilai2");
        } else if (nilai2 < nilai1){
            Console.WriteLine("Nilai2 lebih dari Nilai1");
        }else{
            Console.WriteLine("Nilai1 sama dengan Nilai2");
        }
    }
}