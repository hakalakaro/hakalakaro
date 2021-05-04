using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Oletko mies vai nainen?");
            string b = (Console.ReadLine());
            Console.WriteLine("Hei " + b + ", mikä on ikäsi?");
            int a = int.Parse(Console.ReadLine());
            if (a < 13)
            {
                Console.WriteLine("Mitä poitsu?");
             }
            else if (a < 26)
            {
                Console.WriteLine("Mitä nuori " + b + "?");
             }
            else
            { 
                Console.WriteLine("Olet " + b + " parhaassa iässä!"); 
            }
        }
    }
}
