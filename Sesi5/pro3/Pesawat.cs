using System;

public class Pesawat
{
    public string nama, ketinggian, jumlahPenumpang;
    public int jumlahRoda;
    public void terbang(){
        Console.WriteLine("Pesawat tempur dengan nama {0}, yang mempunyai jumlah roda {1}, sedang berada pada ketinggian {2} dan membawa jumlah penumpang sebanyak {3} orang. Akan meledakan senjata", this.nama, this.jumlahRoda, this.ketinggian, this.jumlahPenumpang);
    }
    public class Pesawat_Tempur:Pesawat{ 
        public void terbang(){
            Console.WriteLine("Pesawat tempur dengan nama {0}, yang mempunyai jumlah roda {1}, sedang berada pada ketinggian {2} dan membawa jumlah penumpang sebanyak {3} orang. Akan meledakan senjata", this.nama, this.jumlahRoda, this.ketinggian, this.jumlahPenumpang);
        }
    }
}