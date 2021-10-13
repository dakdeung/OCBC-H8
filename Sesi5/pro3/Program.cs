using System;


namespace pro3
{
    class Program
    {
        public int bil1, bil2;
        static void Main(string[] args)
        {
            string p = "";
            int pilih = 0;
            do{
                Console.WriteLine("======== Pilih Menu =======");
                Console.WriteLine("1. Pesawat Tempur");
                Console.WriteLine("2. Overiding");
                Console.WriteLine("3. Overide");
                Console.WriteLine("4. Data Diri");
                Console.WriteLine("Masukan Pilihan : ");
                pilih = int.Parse(Console.ReadLine());

                switch(pilih){
                    case 1:{
                        Pesawat();

                        Console.WriteLine("");
                        Console.Write("Kembali ke Menu? (y/n): ");
                        p = Console.ReadLine();
                        Console.WriteLine("");
                        break;
                    }
                    case 2:{
                        Overloading();
                        Console.WriteLine("");
                        Console.Write("Kembali ke Menu? (y/n): ");
                        p = Console.ReadLine();
                        Console.WriteLine("");
                        break;
                    }
                    case 3:{
                        Overide();

                        Console.Write("Kembali ke Menu? (y/n): ");
                        p = Console.ReadLine();
                        Console.WriteLine("");
                        break;
                    }
                    case 4:{
                        Console.WriteLine("Perkenalkan Nama saya Riyan Adriansyah, menurut saya pengalaman selama 5 sesi ini sangat menyenangkan untuk mempelajari C# dan itu menambah ilmu bagi saya karena memang sebelumnya belum pernah mempelajari C#");
                        Console.Write("Kembali ke Menu? (y/n): ");
                        p = Console.ReadLine();
                        Console.WriteLine("");
                        break;
                    }
                }
            }while(p != "n" && pilih < 5);
            
        }

        static void Pesawat(){
            Pesawat pesawat = new Pesawat();
            Pesawat.Pesawat_Tempur psTempur = new Pesawat.Pesawat_Tempur();

            Console.Write("Masukan Nama Pesawat : ");
            pesawat.nama = Console.ReadLine();
            Console.Write("Masukan Jumlah Roda Pesawat : ");
            pesawat.jumlahRoda = int.Parse(Console.ReadLine());
            Console.Write("Masukan Ketinggian Pesawat : ");
            pesawat.ketinggian = Console.ReadLine();
            Console.Write("Masukan Jumlah Penumpang Pesawat : ");
            pesawat.jumlahPenumpang = Console.ReadLine();

            Console.Write("Masukan Nama Pesawat Tempur: ");
            psTempur.nama = Console.ReadLine();
            Console.Write("Masukan Jumlah Roda Pesawat Tempur : ");
            psTempur.jumlahRoda = int.Parse(Console.ReadLine());
            Console.Write("Masukan Ketinggian Pesawat Tempur: ");
            psTempur.ketinggian = Console.ReadLine();
            Console.Write("Masukan Jumlah Penumpang Pesawat Tempur: ");
            psTempur.jumlahPenumpang = Console.ReadLine();

            pesawat.terbang();
            psTempur.terbang();
        }
        
        static void Overloading(){
            string nama;
            double noTelepon;

            Overloading.Data d = new Overloading.Data();
            Console.Write($"Nama: ");
            nama = Console.ReadLine();
            Console.Write($"Nomor Telepon: ");
            noTelepon = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"");
                        
            d.print(nama);
            d.print(noTelepon);
        }
        
        static void Overide(){
            int bilangan1, bilangan2;

            Program over = new Program();
            Console.Write("Bilangan 1: ");
            bilangan1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bilangan 2: ");
            bilangan2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            
            over.bilangan(bilangan1, bilangan2);
            over.penjumlahanPerkaliandll();
            Console.WriteLine("");
                        
                        
            Console.Write("Bilangan 1: ");
            bilangan1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bilangan 2: ");
            bilangan2 = Convert.ToInt32(Console.ReadLine());
            over = new overide();
            over.bilangan(bilangan1, bilangan2);
            over.penjumlahanPerkaliandll();
            Console.WriteLine("");
        }

        public void bilangan(int angka1, int angka2){
            bil1 = angka1;
            bil2 = angka2;
        }

        public virtual void penjumlahanPerkaliandll(){
            Console.WriteLine($"Overiding......----->>>>>>");
            Console.WriteLine($"Hasil penjumlahan angka {bil1} dan angka {bil2} = {bil1 + bil2} ");
            Console.WriteLine($"Hasil perkalian angka {bil1} dan angka {bil2} = {bil1 * bil2}");
        }

        class overide:Program{
            public override void penjumlahanPerkaliandll(){
                Console.WriteLine($"Overiding 2.....----->>>>>");
                Console.WriteLine($"Hasil pembagian angka {bil1} dan angka {bil2} = {bil1 / bil2}");
                Console.WriteLine($"Hasil pengurangan angka {bil1} dan angka {bil2} = {bil1 - bil2}");
            }
        }
    }
}
