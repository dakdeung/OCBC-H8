using System;

public class dataString
{
    public static void Main(String[] args)
    {
        string nama;
        int umur;

        Console.WriteLine("=== PROGRESS PENDAFTARAN PENDUDUK ===");
        Console.Write("Masukan Nama: ");
        nama = Console.ReadLine();
        Console.Write("Masukan Alamat: ");
        var alamat = Console.ReadLine();
        Console.Write("Masukan Umur: ");
        umur = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("Terima Kasih");
        Console.Write("Data Berikut");
        Console.Write($"Nama: {nama}");
        Console.Write($"Alamat: {alamat}");
        Console.Write($"Umur: {umur} tahun");
        Console.Write("SUDAH DISIMPAN");
    }
}