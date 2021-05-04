using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            double metri = 100 , maili = 1609.344 , jaardi = 0.91 , tuuma = 0.0254;
            double metrib;
            Console.WriteLine("Ilmoita pituutesi senttimetreinä");
            int inputnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Pituutesi on metreissä " + "{0:0.00}", inputnumber / (double)metri);
            metrib = inputnumber / (double)metri;
            Console.WriteLine("Pituutesi on maileissa " + "{0:0.00}", metrib / (double)maili);
            Console.WriteLine("Pituutesi on jaardeissa " + "{0:0.00}", metrib / (double)jaardi);
            Console.WriteLine("Pituutesi on tuumissa " + "{0:0.00}", metrib / (double)tuuma);
        }
    }
}
