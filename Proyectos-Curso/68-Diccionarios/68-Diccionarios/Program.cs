using System;
using System.Collections.Generic;

namespace _68_Diccionarios
{
    class Program
    {
        static void Main()
        {
            /* ***** Diccionarios ***** */
            // En c# existen varias clases de diccionarios, pero el mas usado es Dictionary<TKey, TValue>
            // Asi es como se declara e inicializa un diccionario en c#:
            // Dictionary<string, int> contacts = new Dictionary<string, int>();
            // Y asi es como se agregan elementos:
            // concats.Add("Vincent Vega", 15);
            // concats.Add("Mia Wallace", 63);

            // Caracteristicas
            // - Almacenan pares clave-valor
            // - Forman parte del namespace Generic
            // - Las claves deben ser unicas y no deben ser nulas
            // - Los valores si pueden ser nulos o duplicados
            // - Se accede a los valores usando la clave como indice (myDictionary[key])

            Console.WriteLine("***** Ejemplo 1 - Creacion basica de un diccionario string => int *****");
            Dictionary<string, int> contacts = new Dictionary<string, int>();
            contacts.Add("Vincent Vega", 15);
            contacts.Add("Mark Jones", 63);
            foreach (var item in contacts)
            {
                Console.WriteLine($"Dictionary val => {item}");
            }
            Console.WriteLine(contacts["Vincent Vega"]);
            Console.WriteLine(contacts["Mark Jones"]);

            Console.WriteLine("\n");
            Console.WriteLine("***** Ejemplo 2 - Creacion basica de un diccionario int => string *****");
            Dictionary<int, string> numberNames = new Dictionary<int, string>();
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");
            numberNames.Add(3, "Three");
            // numberNames.Add(3, "Three"); // No se pueden agregar key duplicadas o que ya existan porque en tiempo de ejecucion me mostrara el error
            foreach (KeyValuePair<int, string> item in numberNames)
            {
                Console.WriteLine($"clave: {item.Key} => valor: {item.Value}");
            }
            Console.WriteLine("\n");
            foreach (var item in numberNames)
            {
                Console.WriteLine($"clave: {item.Key} => valor: {item.Value}");
            }

            Console.WriteLine("\n");
            Console.WriteLine("***** Ejemplo 3 - Creacion de un diccionario cargando datos desde su instancia *****");
            var countries = new Dictionary<string, string>()
            {
                { "ARG", "Argentina" },
                { "ESP", "España" },
                { "PER", "Perú" },
                { "MEX", "Mexico" }
            };

            foreach (var item in countries)
            {
                Console.WriteLine($"Contry: {item.Key} - {item.Value}");
            }
            Console.WriteLine("\n");
            // Console.WriteLine($"Countries: {countries.ToString()}"); // No funciona el metodo ToString()
            Console.WriteLine(countries["ARG"]); // Argentina
            Console.WriteLine(countries["PER"]); // Peru
            Console.WriteLine(countries["MEX"]); // Mexico
            // Console.WriteLine(countries["COL"]); // Si el elemento no existe, se genera un error de compilacion

            Console.WriteLine("\n");
            //Podemos validar si existe una llave con ContainsKey o un valor con ContainsValue, asi sabremos si existe una llave en un diccionario
            if (countries.ContainsKey("MEX"))
            {
                Console.WriteLine(countries["MEX"]); // Mexico
            }

            Console.WriteLine("\n");
            Console.WriteLine("***** Ejemplo 4 - Validando y agregando valores a un diccionario *****");
            if (!countries.ContainsKey("COL"))
            {
                countries.Add("COL", "Colombia");
            }
            foreach (var item in countries)
            {
                Console.WriteLine($"Contry: {item.Key} - {item.Value}");
            }

            Console.WriteLine("\n");

            Console.WriteLine("***** Ejemplo 5 - Modificando valores de un diccionario *****");
            var countries1 = new Dictionary<string, string>()
            {
                { "ARG", "Argentina" },
                { "ESP", "España" },
                { "PER", "Perú" },
                { "MEX", "Mexico" }
            };

            countries1["MEX"] = "Brasil";
            foreach (var item in countries1)
            {
                Console.WriteLine($"Contry: {item.Key} - {item.Value}");
            }

            Console.WriteLine("\n");

            Console.WriteLine("***** Ejemplo 6 - Eliminado valores de un diccionario *****");
            var countries2 = new Dictionary<string, string>()
            {
                { "ARG", "Argentina" },
                { "ESP", "España" },
                { "PER", "Perú" },
                { "MEX", "Mexico" }
            };

            countries2.Remove("MEX");
            foreach (var item in countries2)
            {
                Console.WriteLine($"Contry: {item.Key} - {item.Value}");
            }

            Console.WriteLine("\n");

            Console.WriteLine("***** Ejemplo 7 - Eliminado todos los valores *****");
            var countries3 = new Dictionary<string, string>()
            {
                { "ARG", "Argentina" },
                { "ESP", "España" },
                { "PER", "Perú" },
                { "MEX", "Mexico" }
            };

            countries3.Clear();
            foreach (var item in countries3)
            {
                Console.WriteLine($"Contry: {item.Key} - {item.Value}");
            }
        }
    }
}
