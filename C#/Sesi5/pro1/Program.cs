using System;

namespace pro1
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop1 = new Laptop();

            Console.Write("Masukan Merk: ");
            laptop1.merk= Console.ReadLine();
            Console.Write("Masukan Ram: ");
            laptop1.ram= int.Parse(Console.ReadLine());
            Console.Write("Masukan Memory: ");
            laptop1.memory= int.Parse(Console.ReadLine());

            Console.WriteLine("\n Merk laptop adalah {0}", laptop1.merk);
            Console.WriteLine("Kapasitas Ram adalah {0}", laptop1.ram);
            Console.WriteLine("Kapasitas Memory adalah {0}", laptop1.memory);

            laptop1.Chatting();
            laptop1.Sosmed();
            laptop1.OnlineShop();

            Console.Read();
        }
    }
}
