using System;

public class Overloading
{
    public class Data
    {
        public string nama;

        public double nomor_telepon;

        public void print(string nama)
        {
            this.nama = nama;
            Console.WriteLine("Nama adalah : {0}", this.nama);
        }
        public void print(double nomor_telepon)
        {
            this.nomor_telepon = nomor_telepon;
            Console.WriteLine("Nomor HP: {0}", this.nomor_telepon);
        }
    }
}