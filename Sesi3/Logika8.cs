using System;

public class Logika8
{
    public static void Main()
    {
        int awal, akhir, bilangan;
        string aritmatika;

        Console.Write("Masukan Angka Awal: ");
        awal = int.Parse(Console.ReadLine());
        Console.Write("Masukan Angka Akhir: ");
        akhir = int.Parse(Console.ReadLine());
        Console.Write("Masukan Operator ( + - * / ): ");
        aritmatika = Console.ReadLine();
        Console.Write("Masukan bilangan : ");
        bilangan = int.Parse(Console.ReadLine());
        
        
        if(awal < akhir){
            do
            {
                Console.WriteLine("Angka = " + awal);
                switch(aritmatika){
                    case "+":{
                        awal += bilangan;
                        break;}
                    case "-":{
                        awal -= bilangan;
                        break;}
                    case "*":{
                        awal *= bilangan;
                        break;}
                    case "/":{
                        awal /= bilangan;
                        break;}
                }

                if(awal > akhir)
                {
                    break;
                }
            } while(awal<akhir);
        }
        else
        {
            do
            {
                Console.WriteLine("Angka = " + awal);
                switch(aritmatika){
                    case "+":{
                        awal += bilangan;
                        break;}
                    case "-":{
                        awal -= bilangan;
                        break;}
                    case "*":{
                        awal *= bilangan;
                        break;}
                    case "/":{
                        awal /= bilangan;
                        break;}
                }

                if(awal < akhir)
                {
                    break;
                }
            } while(awal>akhir);
        }
    }
}