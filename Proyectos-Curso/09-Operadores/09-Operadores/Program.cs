using System;

namespace _09_Operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 5;
            int c = a + b;
            int d = 2;
            int e = 3;

            Console.WriteLine("Varible a = " + a);
            Console.WriteLine("Varible b = " + b);
            Console.WriteLine("Varible c = " + c);
            Console.WriteLine("Varible d = " + d);
            Console.WriteLine("Varible e = " + e);
            Console.WriteLine("\n");
            Console.WriteLine("Sum (a + b): " + (a + b));
            Console.WriteLine("Mult (a * b): " + (a * b));
            Console.WriteLine("Resta (a - b): " + (a - b));
            Console.WriteLine("Division (a / b): " + (a / b));
            Console.WriteLine("\n");
            Console.WriteLine("Operacion 1 (c / a): " + (c / a));
            Console.WriteLine("Operacion 2 (a + b * c): " + (a + b * c));
            Console.WriteLine("Operacion 3 ((a + b) * c): " + ((a + b) * c));
            Console.WriteLine("\n");
            Console.WriteLine("Comp 1 (b > c): " + (b > c));
            Console.WriteLine("Comp 2 (b == c): " + (b == c));
            Console.WriteLine("Comp 3 (b < c): " + (b < c));
            Console.WriteLine("Comp 4 (b < c && a > c): " + (b < c && a > c));
            Console.WriteLine("Comp 5 (b < c && a < c): " + (b < c && a < c));
            Console.WriteLine("Comp 6 (b < c || a > c): " + (b < c || a > c));
            Console.WriteLine("Comp 7 !(b < c || a > c): " + !(b < c || a > c));
            Console.WriteLine("Comp 8 (c != b): " + (c != b));
            Console.WriteLine("Comp 9 !(c != b): " + !(c != b));
            Console.WriteLine("Comp 10 (c % b): " + (c % b));
            Console.WriteLine("Comp 11 (c % d): " + (c % d));
            Console.WriteLine("Comp 12 (c % e): " + (c % e));
        }
    }
}
