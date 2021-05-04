using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            double punta = 0.86; // 1 eur = 0.86 puntaa
            double dollari = 1.18; // 1 eur = 1.18 dollaria
            Console.WriteLine("Ilmoita euromääräinen luku");
                double euro = int.Parse(Console.ReadLine());
            Console.WriteLine("Ilmoittamasi eurosumma " + (double)euro + " on " + (double)euro * (double)dollari + " dollaria");
            Console.WriteLine("ja " + (double)euro * (double)punta + " puntaa"); 
           

            
            

        }
    }
}
