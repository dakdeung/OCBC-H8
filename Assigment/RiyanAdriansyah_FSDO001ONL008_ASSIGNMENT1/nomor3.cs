using System;

public class nomor3{
    public static void Main(){
        int total;
        Console.Write("Masukkan Nilai = ");
        int n = int.Parse(Console.In.ReadLine());
        total = 1;
        Console.Write(n + "! = ");

        for (int i = 1; i <= n; i++)
        {
            total = total * i;

            Console.Write(n - (i - 1));
            if (i != n)
            {
                Console.Write("*");
            }
        }
            Console.WriteLine();
            Console.Write($"Nilai faktorial dari {n} adalah {total}");
    }
}