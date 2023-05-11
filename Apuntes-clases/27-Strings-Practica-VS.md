using System;
using System.Text;

namespace _27_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ***** Ejemplo 1 ***** */
            string number = "1";
            string street = "Palo Alto St";
            string city = "California";
            string address = street + " " + number + " " + city;
            Console.WriteLine(address);

            /* ***** Ejemplo 2 ***** */
            string adress1 = ""; // string.empty
            Console.WriteLine(adress1);
            bool isEmpty;
            if (adress1 == string.Empty)
                isEmpty = true;
            else
                isEmpty = false;
            Console.WriteLine(isEmpty);

            /* ***** Ejemplo 3 ***** */
            string adress2 = ""; // string.empty
            Console.WriteLine(adress2);
            bool isEmpty2;
            if (string.IsNullOrEmpty(adress2))
                isEmpty2 = true;
            else
                isEmpty2 = false;
            Console.WriteLine(isEmpty2);

            /* ***** Ejemplo 4 ***** */
            string adress3 = ""; // string.empty
            bool validAddress = string.IsNullOrEmpty(adress3);
            Console.WriteLine(validAddress);

            /* ***** Ejemplo 5 ***** */
            string adress4 = " California";
            bool validAddress1 = string.IsNullOrWhiteSpace(adress4);
            Console.WriteLine(validAddress1);

            /* ***** Ejemplo 6 ***** */
            // Escapar caracteres especiales en strings
            string textoDeEscape = "Para saber que \"Cambios\" podemos realizar."; // En este caso para escapar las comillas usamos el backslash \ 
            Console.WriteLine(textoDeEscape);

            /* ***** Ejemplo 7 ***** */
            // Si quisieramos escribir en un string \Usuarios\German\Documentos\Datos tendriamos que escapar cada backslach con otro backslash antecedido
            string rutaDatos = "\\Usuarios\\German\\Documentos\\Datos"; // \\string
            Console.WriteLine(rutaDatos);

            /* ***** Ejemplo 8 ***** */
            string rutaAlterna = @"\Usuarios\OtrosUsuarios\Publico\Documentos\Datos";
            Console.WriteLine(rutaAlterna);


            string location1 = street + " " + number + " " + city;
            Console.WriteLine(location1);

            /* ***** Ejemplo 9 ***** */
            string location2 = $"{street} {number} {city}";
            Console.WriteLine(location2);

            /* ***** Ejemplo 10 ***** */
            string location3 = string.Format("{0} {1} {2}", street, number, city);
            Console.WriteLine(location3);

        }
    }
}