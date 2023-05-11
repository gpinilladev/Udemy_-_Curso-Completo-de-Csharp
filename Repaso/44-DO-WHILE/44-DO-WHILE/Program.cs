using System;

namespace _44_DO_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {

            // En escencia un do while funciona igual a un while solo que se evalua la condicion al final
            int i = 0;
            do
            {
                Console.WriteLine($"i: {i}");
                i++;
            } while (i < 15);

            Console.WriteLine("\n");


            // tambien podemos usar el break
            int j = 0;
            do
            {
                if (j == 7)
                    break;
                Console.WriteLine($"j: {j}");
                j++;
            } while (j < 10);

            Console.WriteLine("\n");


            // tambien podemos usar do while anidado aunque no es una buena practica usarlos
            int k = 0;
            do
            {
                Console.WriteLine($"k: {k}");
                k++;
                int l = 1;
                do
                {
                    Console.WriteLine($"l: {l}");
                    l++;
                } while (l < 5);

            } while (k < 10);

            Console.WriteLine("\n");

        }
    }
}