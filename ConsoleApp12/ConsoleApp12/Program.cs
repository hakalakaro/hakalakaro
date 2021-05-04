using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä joku luku.");
            int b = Convert.ToInt32(Console.ReadLine());
            for (int a = b + 1; a < b + 10; a++)
                Console.WriteLine(a);
            

            
        }
    }
}
