using System;
namespace _42_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ***** While ***** */
            /*
            while(condition)
            {
                // Code block
            }
            */

            int val = 0; // Inicialicion
            while (val < 10) // Condicion
            {
                Console.WriteLine($"{val} - Hello World!"); // Bloque de codigo
                val++; // Incremento
            }

            Console.WriteLine("\n");


            // Uso de break
            int i = 0; // Inicialicion
            while (i < 10) // Condicion
            {
                if (i == 8)
                {
                    break; // Break es la palabra reservada que nos permite romper el loop del while
                }
                Console.WriteLine($"{i} - Hello World!"); // Bloque de codigo
                i++; // Incremento
            }

            Console.WriteLine("\n");


            // Debemos tener cuidado con los loop infinitos ya que wl while se presta para este tipo de error
            /*
            while (true)
            {
                Console.WriteLine("Loop infinito");
            }
            */

            // Uso de while inidados
            // Al igual que el for pordemos anidar tantos loops while como deseemos
            // No es buena practica
            int a = 0;
            int b = 1;

            while (a < 2)
            {
                Console.WriteLine($"a: {a}");
                a++;
                while (b < 2)
                {
                    Console.WriteLine($"b: {b}");
                    b++;
                }
            }
        }
    }
}