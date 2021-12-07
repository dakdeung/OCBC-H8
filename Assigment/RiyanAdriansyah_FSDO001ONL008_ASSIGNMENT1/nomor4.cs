using System;

public class nomor4
{
    public static void Main()
    {
        int angka, reverse = 0, temp;
        Console.Write("Masukan Angka : ");
        angka = int.Parse(Console.ReadLine());
        while(angka != 0){
            temp = angka%10;
            reverse = reverse*10 + temp;
            angka /= 10;
        }
        Console.WriteLine($"Reverse: {reverse}");
    }
}