using System;

namespace _27_Strings
{
    class Program
    {
        static void Main(String[] args)
        {
            /* ***** Ejemplo 1 ***** */
            string number = "1";
            string newNumber = "123";

            string street = "Palo Alto St";
            string newStreet = "Avenida Siempre Viva";

            string city = "California";
            string newCity = "Denver";

            string address = street + " " + number + " " + city;
            string newAddress = newStreet + " " + newNumber + " " + newCity;

            Console.WriteLine(address);
            Console.WriteLine(newAddress);

            /* ***** Ejemplo 2 ***** */
            string address1 = ""; // string.empty
            Console.WriteLine(address1);
            bool isEmpty;
            if (address1 == string.Empty)
                isEmpty = true;
            else
                isEmpty = false;
            Console.WriteLine(isEmpty);

            /* ***** Ejemplo 3 ***** */
            string address2 = ""; // string.empty
            Console.WriteLine(address2);
            bool isEmpty2;
            if (string.IsNullOrEmpty(address2))
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
            Console.WriteLine("\n");
            // Escapar caracteres especiales en strings
            string textoDeEscape = "Para saber que \"Cambios\" podemos realizar."; // En este caso para escapar las comillas usamos el backslash \ 
            Console.WriteLine(textoDeEscape);

            /* ***** Ejemplo 7 ***** */
            Console.WriteLine("\n");
            // Si quisieramos escribir en un string \Usuarios\German\Documentos\Datos tendriamos que escapar cada backslach con otro backslash antecedido
            string rutaDatos = "\\Usuarios\\German\\Documentos\\Datos"; // \\string
            Console.WriteLine(rutaDatos);

            /* ***** Ejemplo 8 ***** */
            Console.WriteLine("\n");
            string rutaAlterna = @"\Usuarios\OtrosUsuarios\Publico\Documentos\Datos";
            Console.WriteLine(rutaAlterna);


            Console.WriteLine("\n");
            string location1 = street + " " + number + " " + city;
            Console.WriteLine(location1);

            /* ***** Ejemplo 9 ***** */
            string location2 = $"{street} {number} {city}";
            Console.WriteLine(location2);

            /* ***** Ejemplo 10 ***** */
            Console.WriteLine("\n");
            string location3 = string.Format("{0} {1} {2}", street, number, city);
            Console.WriteLine(location3);

        }


    }
}