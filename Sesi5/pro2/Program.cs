using System;

namespace pro2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pesawat pesawat = new Pesawat();
            Console.Write("Masukan Nama Pesawat: ");
            pesawat.nama = Console.ReadLine();
            Console.Write("Masukan Ketinggian: ");
            pesawat.ketinggian = Console.ReadLine();

            pesawat.terbang();
            pesawat.sudahterbang();
            Console.Read();

        }
    }
}
