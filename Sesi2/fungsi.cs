using System;

public class fungsi
{
    public static void Main(string[] args){
        Console.WriteLine("Hello World");
        Console.WriteLine("Hello riyan adriansyah");
        Console.WriteLine("Selamat datang di program bootcamp OCBC");
        Console.WriteLine("Tahap 1 saya akan belajar C#");

        string nama = "foxi";
        double[] harga = {10.000,5.000,20.000};
        int[] jumlah = {10,7,13};
        double[] total = {0.0,0.0,0.0};
        double totalharga = 0.0;
        int jumlahsemua = 0;

        // double harga1 = 10.000, harga2 = 5.000, harga3 = 20.000;
        // int jumlah1 = 10, jumlah2 = 7, jumlah3 = 13;

        for(int i = 0; i < 3; i++){
            total[i] = harga[i]*jumlah[i];
            totalharga += harga[i];
            jumlahsemua += jumlah[i];
        }
        // double total1 = harga1*jumlah1;
        // double total2 = harga2*jumlah2;
        // double total3 = harga3*jumlah3;

        // double totalharga = total1+total2+total3;
        // int jumlahsemua = jumlah1+jumlah2+jumlah3;

        Console.WriteLine();
        Console.WriteLine("nama customer : " + nama);
        for(int i =0;i<3;i++){
        Console.WriteLine("barang" + i +" ber jumlah : " + jumlah[i] + " dengan harga " + harga[i] + " yang harus dibayar " + total[i]);    
        }
        // Console.WriteLine("barang 1 ber jumlah : " + jumlah1 + " dengan harga " + harga1 + " yang harus dibayar " + total1);
        // Console.WriteLine("barang 2 ber jumlah : " + jumlah2 + " dengan harga " + harga2 + " yang harus dibayar " + total2);
        // Console.WriteLine("barang 3 ber jumlah : " + jumlah3 + " dengan harga " + harga3 + " yang harus dibayar " + total3);
        Console.WriteLine();
        Console.WriteLine("jumlah semua barang : " + jumlahsemua);
        Console.WriteLine("total harga semua barang : " + totalharga);
        Console.WriteLine();
    }
}