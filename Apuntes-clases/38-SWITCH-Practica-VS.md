using System;

namespace _38_Switch
{
    class Program
    {
        static void Main()
        {
            /* ********** Switch evaluacion de cadena de texto ********** */

            // Texto que pregunta al usuario la opcion que desea
            Console.WriteLine("Do you like C# so far? (yes / no / maybe)");

            // Se lee la entra de texto con Console.ReadLine() y almacenamos la entrada de texto en una
            // variable de tipo string, en este caso "input"
            string input = Console.ReadLine();

            // Imprimimos lo que el usuario ingreso por teclado
            // System.Console.WriteLine(input);

            // input.ToLower() nos permite convertir la entrada de texto del usuario a minusculas
            switch (input.ToLower())
            {
                case "yes" or "y": // Opcion "yes" o "y"
                    Console.WriteLine("That is great!");
                    break;

                case "no" or "n": // Opcion "no" o "n"
                    Console.WriteLine("That is no so good!");
                    break;

                case "maybe" or "m": // Opcion "maybe" o "m"
                    Console.WriteLine("It'll get better!");
                    break;

                default: // Default - Opcion incorrecta si escribe algun texto diferente al de las opciones "yes", "y", "no", "n", "maybe", "m"
                    Console.WriteLine("wasn't an option!");
                    break;
            }

            /* ********** Switch evaluacion de un entero ********** */
            int x = 10;
            switch (x) // Evaluacion de x como un entero
            {
                case 5:
                    Console.WriteLine($"Value of x = {x} - 5");
                    break;
                case 10:
                    Console.WriteLine($"Value of x = {x} - 10");
                    break;
                case 15:
                    Console.WriteLine($"Value of x = {x} - 15");
                    break;
                default:
                    Console.WriteLine("Unknown value!");
                    break;
            }

            /* ********** Switch evaluacion de condicion ********** */
            int y = 10;
            switch (y + 5) // Condicion en el switch
            {
                case 5:
                    Console.WriteLine($"Value of y = {y} - 5");
                    break;
                case 10:
                    Console.WriteLine($"Value of y = {y} - 10");
                    break;
                case 15:
                    Console.WriteLine($"Value of y = {y} - 15");
                    break;
                default:
                    Console.WriteLine("Unknown value!");
                    break;
            }


            /* ********** Switch evaluacion de condicion ********** */
            int z = 10;
            switch (z - 6) // Condicion en el switch
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine($"Value of z < 5");
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    Console.WriteLine($"Value of z <= 10 and z > 5");
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    Console.WriteLine($"Value of z <= 15 and z > 10");
                    break;
                default:
                    Console.WriteLine("Unknown value!");
                    break;
            }

            /* ********** Switch anidacion ********** */
            int a = 10;
            switch (a + 5) // Condicion en el switch
            {
                case 5:
                    Console.WriteLine($"Value of a = {a} - 5");
                    break;
                case 10:
                    Console.WriteLine($"Value of a = {a} - 10");
                    break;
                case 15:
                    // Console.WriteLine($"Value of a = {a} - 15");
                    // Podemos anidar un switch dentro de un case y podemos anidar infinitos switch dentro de cases aun no es buena practica
                    switch (a - 6)
                    {
                        case 4:
                            Console.WriteLine($"Value of a is 4");
                            break;
                    }

                    break;
                default:
                    Console.WriteLine("Unknown value!");
                    break;
            }

        }
    }
}
