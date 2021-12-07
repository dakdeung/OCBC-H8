using System;

public class dataString
{
    public static void Main(String[] args)
    {
        int pertama, kedua, ketiga, total;
        double rata;

        Console.WriteLine("=== PROGRESS PENDAFTARAN PENDUDUK ===");
        Console.Write("Masukan nilai PERTAMA: ");
        pertama = int.Parse(Console.ReadLine());
        Console.Write("Masukan nilai KEDUA: ");
        kedua = int.Parse(Console.ReadLine());
        Console.Write("Masukan nilai KETIGA: ");
        ketiga = int.Parse(Console.ReadLine());

        total = pertama + kedua + ketiga;
        rata = total / 3.0;
        Console.WriteLine();
        Console.WriteLine("Total Nilai adalah: " + total);
        Console.WriteLine("Rata Rata Nilai adalah " + rata);
        Console.Read();
    }
}