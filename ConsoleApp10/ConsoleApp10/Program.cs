using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {

            int a;
            Console.WriteLine("Mikä on ikäsi?");
            a = int.Parse(Console.ReadLine());
            string b;
        Start:
            Console.WriteLine("Oletko Mies vai Nainen? (käytä isoa alkukirjainta)");
            b = Console.ReadLine();
            if (a < 14 && b == "Mies")
            {
                Console.WriteLine("Mitä poitsu?");
            }
            else if (a <= 25 && b == "Mies")
            {
                Console.WriteLine("Mitä nuori " + b + "?");
            }
            else if (a <= 56 && b == "Mies")

            {
                Console.WriteLine("Olet " + b + " parhaassa iässä!");
            }
            else if (a < 14 && b == "Nainen")
            {
                Console.WriteLine("Mitä tyttö?");
            }
            else if (a <= 26 && b == "Nainen")
            {
                Console.WriteLine("Mitä nuori " + b + "?");
            }
            else if (a <= 56 && b == "Nainen")
            {
                Console.WriteLine("Olet " + b + " parhaassa iässä!");
            }
            else if (a >= 56)
                Console.WriteLine("Hei seniori! :-)");
            else
            {
                Console.WriteLine("muistathan käyttää isoa alkukirjainta!");
                goto Start;
            }



            

        }
    }
}
            

