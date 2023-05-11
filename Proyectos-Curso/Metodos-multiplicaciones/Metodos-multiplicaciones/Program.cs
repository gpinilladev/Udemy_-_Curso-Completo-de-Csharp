using System;

namespace Metodos_multiplicaciones
{
    class Program
    {
        static void Main()
        {
            int resultado;
            resultado = multiplicar(2, 2);
            Console.WriteLine("El resultado es: " + resultado);
        }

        public static int multiplicar(int numberOne = 0, int numberTwo = 0)
        {
            return numberOne * numberTwo;
        }
    }

    class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
