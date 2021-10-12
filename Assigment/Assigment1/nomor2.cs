using System;

public class nomor2
{
    public static void Main()
    {
      int baris,angka = 1;
      int ctr = 5;    
   
      Console.Write("Masukan jumlah baris : ");
      baris = int.Parse(Console.ReadLine());    
   
      for (int i = 1; i <= baris; i++) {
         for(int k = baris-i; k>=1;k--){
            Console.Write(" ");
         }
         for (int j = 0; j <= (ctr / 2); j++) 
         {
            Console.Write(angka++);
         }
         angka--;
         angka--;
   
         for (int j = 0; j < (ctr / 2); j++) {
            Console.Write(angka--);
         }
         ctr = ctr + 2;
         angka = 1;
         Console.Write("\n");
      }
    }
}