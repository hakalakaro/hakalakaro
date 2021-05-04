using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Paistaako aurinko? (K/E)");
            string a = Console.ReadLine();
            Console.WriteLine("Sataako? (K/E)");
            string b = Console.ReadLine();
            Console.WriteLine("Onko lämpötila >0? (K/E)");
            string c = Console.ReadLine();
            if (a == "K" && b == "K" && c == "K")
            {
                Console.WriteLine("Aurinko paistaa ja vettä sataa, taitaa tulla kesä!");
            }
            else if (a == "E" && b == "K" && c == "K")
            {
                Console.WriteLine("Syksy saapui, tuuli vei lehdet mennessään.");
            }
            else if (a == "E" && b == "E" && c == "K" || a == "K" && b == "E" && c == "K") 
            {
                Console.WriteLine("Jo joutui armas aika ja suvi suloinen.");
            }
            else if (a == "E" && b == "E" && c == "E") 
            {
                Console.WriteLine("taitaa olla pilvetön ja sateeton päivä.");
            }
            else if (a == "E" && b == "K" && c == "E") 
            {
                Console.WriteLine("sade tekee hyvää luonnolle.");
            }
            else if (a == "K" && b == "E" && c == "E")
            {
                Console.WriteLine("aurinkoista päivää!");
            }

        }
    }
}
