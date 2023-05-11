using System;

namespace MultiploDeTresApp
{
    class MultiploDeTres
    {
        static void Main()
        {
            Console.WriteLine("********** Multiplo de tres **********");
            Console.WriteLine("Ingrese un numero: ");
            var numberUser = Console.ReadLine()!;
            // Console.WriteLine(numberUser);
            int numberUserConverted;
            var validNum = int.TryParse(numberUser, out numberUserConverted);
            if (validNum)
            {
                Console.WriteLine(numberUserConverted);
                string message = ((numberUserConverted / 3) == 0) ? $"El numero {numberUserConverted} si es multiplo de 3" : $"El numero {numberUserConverted} no es multiplo de 3";
                Console.WriteLine(message);
            }

        }
    }
}