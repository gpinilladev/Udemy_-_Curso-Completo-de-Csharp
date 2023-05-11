using System;

namespace _40_For
{
    class Program
    {
        static void Main()
        {
            /* ********** For ********** */

            // Estructura

            /*
            for (initializer; condition; iterator)
            {
                // Code block
            }
            */

            // -> Ejemplo
            // For loop incremental
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Value i => {i}");
            }
            // La sentencia imprimira los numero del 0 al 9

            Console.WriteLine("\n");

            // For loop reverse
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine($"Value i => {i}");
            }
            // La sentencia imprimira los numero del 10 al 1

            Console.WriteLine("\n");

            // For loop break
            // Podemos romper la secuencia del for loop con la palabra break;
            // En el siguiente ejemplo se rompe la secuencia del for cuando i es igual a 4
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Value i => {i}");
                if (i == 4)
                    break;
            }

            Console.WriteLine("\n");

            // For loop anidado
            // Las buenas practicas dicen que en lo posible no debemos usar loops anidados
            // Pero en algunas ocasiones necesitaremos de iterar una matriz y esta es la forma que expone el lenguaje
            // Podemos hacer cuantos loops anidados querramos
            for (int i = 0; i < 5; i++)
            {
                for (int j = i; j < 10; j++)
                {
                    Console.WriteLine($"i => {i}, j=> {j}");
                }
            }


        }
    }
}
