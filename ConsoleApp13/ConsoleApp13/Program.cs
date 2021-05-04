using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Syötä joku luku.");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int a = 1; a <= b; a++)
            {
                for (int c = 1; c <= a; c++)
                {
                    Console.Write(c + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
