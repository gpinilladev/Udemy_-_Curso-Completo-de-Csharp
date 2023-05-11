using System;

namespace FirstApplication
{
    class Program
    {
        protected static void Main(string[] args)
        {
            string nameUser = "German Pinilla";
            bool student = true;
            System.Int32 edad = 33; // Forma de definir un entero en .NET Framework
            Console.WriteLine(Saludo(nameUser, student, edad));
        }

        private static string Saludo(string nameUser, bool student, System.Int32 edad)
        {
            string message = "";
            if (student) {
                System.Console.WriteLine(nameUser, student, edad);
                message = "Hola estudiante " + nameUser + " de " + edad + " años";
            } else {
                message = "Hola usuario " + nameUser + " de " + edad + " años";
            }
            return message;
            
        }
    }
}
