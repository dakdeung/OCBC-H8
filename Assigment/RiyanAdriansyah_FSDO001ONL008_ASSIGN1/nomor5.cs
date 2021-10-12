using System;

public class nomor4
{
    public static void Main()
    {
        int angka, temp;
        string spell = "";
        Console.Write("Masukan Angka : ");
        angka = int.Parse(Console.ReadLine());
        while(angka != 0){
            temp = angka%10;
            switch(temp){
                case 0:{
                    spell = "Zero " + spell;
                    break;}
                case 1:{
                    spell = "One " + spell;
                    break;}
                case 2:{
                    spell = "Two " + spell;
                    break;}
                case 3:{
                    spell = "Three " + spell;
                    break;}
                case 4:{
                    spell = "Four " + spell;
                    break;}
                case 5:{
                    spell = "Five " + spell;
                    break;}
                case 6:{
                    spell = "Six " + spell;
                    break;}
                case 7:{
                    spell = "Seven " + spell;
                    break;}
                case 8:{
                    spell = "Eight " + spell;
                    break;}
                case 9:{
                    spell = "Nine " + spell;
                    break;}
            }
            angka /= 10;
        }
        Console.WriteLine($"Terbilang: {spell}");
    }
}