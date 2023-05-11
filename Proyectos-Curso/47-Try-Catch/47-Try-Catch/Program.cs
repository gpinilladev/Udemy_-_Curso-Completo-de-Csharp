using System;

namespace _47_Try_Catch
{
    class Program
    {
        static void Main()
        {

            // Estructura del try/catch
            /*
            try
            {
                // Block of code to try
            }
            catch (error)
            {
                // Block of code to handle errors 
            }
            finally
            {
                // Block of code that always run 
            }
            */

            // Ejemplo - Excepciones disparadas por .NET

            try
            {

                string name = "John";
                int number = int.Parse(name);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Cannot parse that! Error => {ex}");
            }


            // Ejemplo - Excepciones disparadas por el programador (manualmente)
            /*
            string name1 = "Allanrr";
            if (name1 != "Allan")
                throw new Exception("EL nombre deberia ser Allan");
            */

            // Ejemplo 3
            try
            {
                Console.WriteLine("Enter a number:");
                var input = int.Parse(Console.ReadLine());
                Console.WriteLine($"The number is: {input}, {input * 2}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Please retry");
            }


            // Ejemplo 4 - Se debe dejar el catch mas generico de captura de ultimas para para que no genere error
            Console.WriteLine("Please enter a number to divide to 100:");
            try
            {
                int num = int.Parse(Console.ReadLine());
                int result = 100 / num;
                Console.WriteLine($"Result: {result}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }


            // Ejemplo 5 - Uso de throw
            /*
            try
            {
                sum()
            }
            catch (Exception ex)
            {

            }
            */
            sum();
        }

        // Excepciones de no implementacion - Es una excepcion para nosotros los programadores
        public static void sum() {
            throw new NotImplementedException();
        }

    }
}
