using System;
using System.Text;

namespace _29_String_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "1";
            string street = "Palo Alto St.";
            string city = "California";

            string location = street + " " + number + " " + city;
            Console.WriteLine(location);

            Console.WriteLine("\n");

            /* ********** String Builder ********** */
            // Nos permite extender el scope de un string y nos ayuda a mejorar el performance
            /* ***** Ejemplo 1 - Append ***** */
            StringBuilder sb1 = new StringBuilder();
            sb1.Append(street); // Append agrega una cadena de texto en la misma linea
            sb1.Append(number);
            sb1.Append(city);
            Console.WriteLine(sb1.ToString()); // El resultado sera => Palo Alto St.1California

            Console.WriteLine("\n");

            /* ***** Ejemplo 2 - AppendLine ***** */
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(street);// AppendLine agrega una cadena de texto en la siguiente linea - como si se agregara un enter enter cadenas
            sb.AppendLine(number);
            sb.AppendLine(city);
            Console.WriteLine(sb.ToString());// El resultado sera =>
                                             // Palo Alto St.
                                             // 1
                                             // California

            Console.WriteLine("\n");

            /* ***** Ejemplo 3 - Insert ***** */
            StringBuilder sb2 = new StringBuilder("Hi Wick");
            sb2.Insert(2, " John");
            Console.WriteLine(sb2.ToString()); // El resultado sera => Hi John Wick

            Console.WriteLine("\n");

            /* ***** Ejemplo 4 - Remove ***** */
            StringBuilder sb3 = new StringBuilder("Hi there!");
            sb3.Remove(2, 6);
            Console.WriteLine(sb3.ToString()); // El resultado sera => Hi!

            Console.WriteLine("\n");

            /* ***** Ejemplo 5 - Remove ***** */
            StringBuilder sb4 = new StringBuilder("Hi there there there there there");
            sb4.Replace("there", "John");
            Console.WriteLine(sb4.ToString()); // El resultado sera => Hi John John John John John

        }
    }
}