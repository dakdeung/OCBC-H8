using System;

public class Logika4
{
    public static void Main()
    {
        string nama;
        int nilai;

        Console.Write("Nama: ");
        nama = Console.ReadLine();
        Console.Write("Nilai: ");
        nilai = int.Parse(Console.ReadLine());
        if(nilai <60){
            Console.WriteLine("============");
            Console.WriteLine("Nama : " + nama);
            Console.WriteLine("Nilai Kamu C");
            Console.WriteLine("============");
        }
        else if (nilai <80){
            Console.WriteLine("============");
            Console.WriteLine("Nama : " + nama);
            Console.WriteLine("Nilai Kamu B");
            Console.WriteLine("============");
        }
        else{
            Console.WriteLine("============");
            Console.WriteLine("Nama : " + nama);
            Console.WriteLine("Nilai kamu A");
            Console.WriteLine("============");
        }
    }
}