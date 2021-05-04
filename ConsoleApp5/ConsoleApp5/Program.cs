using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ilmoita pituutesi senttimetreinä");
            int inputnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Pituutesi on " + (float)inputnumber / 100 + " metriä  " + (double)inputnumber / 1609.344 + " mailia");
            
            


        }
    }
}
