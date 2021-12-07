using System;

public class data3
{
    public static void Main()
    {

        int[] aAngka = new int[5];
        string[] aNama = new string[] {"Joni", "Meri", "David"};
        object[] aObjek = {20.33, "Lorem ipsum", DateTime.Now, true, 'D'};

        aAngka[0] = 1;
        Console.WriteLine("Angka yang anda buat : " + aAngka[0]);
        Console.WriteLine("Nama anda : " + aNama[0]);
        Console.WriteLine("Objek anda (tanggal dan waktu) : " +aObjek[2]);
        Console.WriteLine("Press any key to continue . . . .");
    }
}