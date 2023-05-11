using System;

namespace invertirCadenaDeTexto
{
    class InvertirTexto
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** Invertir cadena **********");
            Console.WriteLine("* Por favor ingrese la cadena de texto: ");
            var cadenaDeTexto = Console.ReadLine()!;
            var cadenaDeTextoConvertida = cadenaDeTexto.Reverse().ToArray(); // Convertimos el texto en un array y lo invertimos
            var cadenaInvertida = "";
            Console.WriteLine("\n* Cadena invertida: ");
            foreach (var item in cadenaDeTextoConvertida)
            {
                // Console.WriteLine(item);
                cadenaInvertida += item;
            }
            Console.WriteLine(cadenaInvertida);

        }
    }
}