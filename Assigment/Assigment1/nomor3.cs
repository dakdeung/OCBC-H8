using System;

public class nomor3{
    public static void Main(){
        int h;
        Console.Write("Masukkan Nilai N = ");
        int n = int.Parse(Console.In.ReadLine());
        h = 1;
        Console.Write(n + "! = ");

        for (int i = 1; i <= n; i++)
        {
            h = h * i;

            Console.Write(n - (i - 1));
            if (i != n)
            {
                Console.Write("*");
            }
        }
            Console.WriteLine();
            Console.Write(n + "!");
            Console.Write(" = ");

            Console.WriteLine(h);
            Console.ReadLine();
    }
}