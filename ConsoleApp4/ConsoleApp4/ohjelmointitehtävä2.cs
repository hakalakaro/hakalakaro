using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 1;
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;
            
            Console.WriteLine("Laskuri");
            Console.Write("1*5 = ");
            Console.WriteLine(a*e);
            Console.Write("2*5 = ");
            Console.WriteLine(b*e);
            Console.Write("3*5 = ");
            Console.WriteLine(c*e);
            Console.Write("4*5 = ");
            Console.WriteLine(d*e);
            Console.Write("5*5 = ");
            Console.WriteLine(e*e);
            Console.WriteLine();
            Console.WriteLine("Valitse numero 0-10 väliltä");
            int inputnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} * {1} = {2}     {0} / {1} = {3}     {0} % {1} = {4}", inputnumber, a, inputnumber * a, inputnumber / a, inputnumber % a);
            Console.WriteLine("{0} * {1} = {2}     {0} / {1} = {3}     {0} % {1} = {4}", inputnumber, b, inputnumber * b, inputnumber / b, inputnumber % b);
            Console.WriteLine("{0} * {1} = {2}    {0} / {1} = {3}     {0} % {1} = {4}", inputnumber, c, inputnumber * c, inputnumber / c, inputnumber % c);
            Console.WriteLine("{0} * {1} = {2}    {0} / {1} = {3}     {0} % {1} = {4}", inputnumber, d, inputnumber * d, inputnumber / d, inputnumber % d);
            Console.WriteLine("{0} * {1} = {2}    {0} / {1} = {3}     {0} % {1} = {4}", inputnumber, e, inputnumber * e, inputnumber / e, inputnumber % e);
        }
    }
}
