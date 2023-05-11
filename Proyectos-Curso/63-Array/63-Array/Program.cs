using System;

namespace _63_Array
{
    class Program
    {
        static void Main()
        {
            /* ***** Array ***** */
            // Un array funciona como una coleccion de elementos
            // como por ejemplo strings, numeros enteros, etc. En general,
            // se utilizan para agrupar elementos en unico grupo y realizar
            // diversas operaciones en ellos como por ejemplo: iterarlos, ordenarlos
            // cambiar el orden de los elementos, etc.

            // Declaracion de variables de tipo array
            // string[] texts = new String[5] // 5 es la cantidad de elementos
            // texts[0] = "Quentin Tarantino"; // En este caso agregamos un valor en el indice 0 del array
            // texts[3] = "Tack Lemon"; // Podemos tambien agregar valor a inidices aleatorios y aplicaria, en este caso en la posicion 3

            Console.WriteLine(" ***** Ejemplo 1 - Array de strings *****");
            string[] texts = new String[5];
            texts[0] = "Quentin Tarantino";
            texts[3] = "Jack Lemon";

            for (int i = 0; i < texts.Length; i++)
            {
                Console.WriteLine(texts[i]);
            }

            Console.WriteLine("\n");
            Console.WriteLine(" ***** Ejemplo 2 - Array de enteros *****");
            // tambien podemos inicializar un array con todos sus valores
            // int[] numbers = new int[4]{2,7,6,9}; // Esta es una forma mas sintactica de declaracion de arrays con valores
            int[] numbers = {4, 6, 8, 10}; // Esta es una forma mas sencilla de declaracion de arrays con valores
            for (int i = 0; i < numbers.Length; i++) // Length nos permite conocer el tamaño de nuestro array
            {
                Console.WriteLine($"Value index {i} => {numbers[i]}");
            }

            Console.WriteLine("\n");
            Console.WriteLine(" ***** Ejemplo 3 - Array de enteros - practica *****");
            int[] numbers1 = new int[5];
            numbers1[0] = 2; // Asignacion de valores de la coleccion por indice
            numbers1[1] = 4; // Asinacion de valores de la coleccion por indice
            numbers1[2] = 6; // Asignacion de valores de la coleccion por indice
            numbers1[3] = 8; // Asignacion de valores de la coleccion por indice
            numbers1[4] = 10; // Asignacion de valores de la coleccion por indice

            //Console.WriteLine(numbers1[0]); // Lectura de valores de la coleccion por indice
            //Console.WriteLine(numbers1[1]); // Lectura de valores de la coleccion por indice
            //Console.WriteLine(numbers1[4]); // Lectura de valores de la coleccion por indice

            for (int i = 0; i < numbers1.Length; i++)
            {
                Console.WriteLine($"Value to index {i} => {numbers1[i]}");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < numbers1.Length; i++)
            {
                numbers1[i] = numbers1[i] + 10; // Podemos actualizar el valor de cada posicion de la coleccion apuntando a su indice y asignando un valor
                Console.WriteLine($"Value to index {i} => {numbers1[i]}");
            }

            Console.WriteLine("\n");
            Console.WriteLine(" ***** Ejemplo 4 - Foreach - practica *****");
            // Podemos tambien recorrer nuestras colecciones de forma mas sencilla con foreach
            foreach (var item in numbers1)
            {
                Console.WriteLine($"Value to item => {item}");
            }

        }
    }
}
