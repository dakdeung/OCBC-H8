using System;

public class nomor1
{
    public static void Main()
    {
      char huruf = 'A';
      int baris;
      int ctr = 1;    
   
      Console.Write("Masukan jumlah baris : ");
      baris = int.Parse(Console.ReadLine());    
   
      for (int i = 1; i <= baris; i++) {
         for(int k = baris-i; k>=1;k--){
            Console.Write(" ");
         }
         for (int j = 0; j <= (ctr / 2); j++) 
         {
            Console.Write(huruf++);
         }
         huruf--;
         huruf--;
   
         for (int j = 0; j < (ctr / 2); j++) {
            Console.Write(huruf--);
         }
         ctr += 2;
         huruf = 'A';
         Console.Write("\n");
      }
    }
}