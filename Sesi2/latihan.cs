using System;

public class dataString
{
    public static void Main(String[] args)
    {
        int pertama, kedua, ketiga, total;
        double rata;

        Console.Write("Username: ");
        string username = Console.ReadLine();
        Console.Write("Password: ");
        string password = Console.ReadLine();
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Enter Gender (F/M): ");
        string gender = Console.ReadLine();
        Console.Write("Enter Status Nikah (Y/N): ");
        string status = Console.ReadLine();

        bool isAdult = age > 18;
        bool isPasswordValid = password == "OCBC";
        bool isUsername = username == "riyan";


        if(isAdult && isUsername && isPasswordValid)
        {

            Console.Write("Masukan nilai PERTAMA: ");
            pertama = int.Parse(Console.ReadLine());
            Console.Write("Masukan nilai KEDUA: ");
            kedua = int.Parse(Console.ReadLine());
            Console.Write("Masukan nilai KETIGA: ");
            ketiga = int.Parse(Console.ReadLine());

            total = pertama + kedua + ketiga;
            rata = total / 3.0;

            Console.WriteLine("=== Biodata ===");
            Console.WriteLine("Umur : " + age);
            Console.WriteLine("Username : " + username);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Status Nikah : " + status);
            Console.WriteLine("=== Aritmatika ===");
            Console.WriteLine("Total Nilai adalah : " + total);
            Console.WriteLine("Rata Rata Nilai adalah : " + rata);
            Console.Read();
        }
        else 
        {
            Console.WriteLine("Sorry, try again!");
        }
    }
}