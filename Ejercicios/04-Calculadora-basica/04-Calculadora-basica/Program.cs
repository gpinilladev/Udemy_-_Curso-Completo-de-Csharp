using System;

namespace CalculadoraBasicaApp
{
    class CalculadoraBasica
    {
        static void Main()
        {
            Console.WriteLine("* *************** Calculadora basica *************** *");
            Console.WriteLine("Ingrese primer digito: ");
            double digito1;
            bool validaDigito1 = double.TryParse(Console.ReadLine()!, out digito1);

            Console.WriteLine("Ingrese segundo digito: ");
            double digito2;
            bool validaDigito2 = double.TryParse(Console.ReadLine()!, out digito2);
            Console.WriteLine("\n-----------------------\n");
            Console.WriteLine("Por favor, digite el número la operacion que desea realizar: \n  (1) Suma\n  (2) Resta\n  (3) Multiplicacion\n  (4) Division\n");
            int operacion;
            bool validaOperacion = int.TryParse(Console.ReadLine()!, out operacion);

            if (validaDigito1 && validaOperacion && validaDigito2)
            {
                double resultado = 0;
                string textOp = "";
                switch (operacion)
                {
                    case 1:
                        resultado = digito1 + digito2;
                        textOp = "suma";
                        break;
                    case 2:
                        resultado = digito1 - digito2;
                        break;
                        textOp = "resta";
                    case 3:
                        resultado = digito1 * digito2;
                        textOp = "multiplicacion";
                        break;
                    case 4:
                        resultado = digito1 / digito2;
                        textOp = "division";
                        break;
                }

                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine($"- El resultado de la { textOp } es {resultado} -");
                Console.WriteLine("-------------------------------------------------");
            }


            
        }
    }
}