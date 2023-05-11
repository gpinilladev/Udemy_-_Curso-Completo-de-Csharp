using System;

namespace _02_ImprimirDatos
{
    class Program
    {
        protected static void Main(string[] args)
        {
            string nameUser = "German Pinilla"; // Definimos una variable para el nombre del usuario
            string dataMessage = message(nameUser); // Pasamos como argumento de la funcion 'message' el nombre del usuario
            Console.WriteLine(dataMessage); // Imprimimos la variable 'dataMessage' que contiene el mensaje devuelto por la funcion 'message'

            string newDataUser = "Luis Diaz";
            string dataMessage2 = message(newDataUser);
            Console.WriteLine(dataMessage2);

            string User3 = "Gabriel Garcia Marquez";
            string dataMessage3 = message(User3);
            Console.WriteLine(dataMessage3);

            Console.WriteLine("\n *************************** \n");
            string data;
            for (int i = 0; i < 5; i++)
            {
                data = "User" + (i + 1);
                string dataNewMessage = message(data);
                Console.WriteLine(dataNewMessage);
            }
        }

        // Definimos una funcion que nos retorna un mensaje para un usuario
        private static string message(string nameUser)
        {
            return "Hello " + nameUser + ", Welcome to my C# App!"; // Retornamos el mensaje modificado con el nombre del usuario que se paso como argumento
        }
    }
}
