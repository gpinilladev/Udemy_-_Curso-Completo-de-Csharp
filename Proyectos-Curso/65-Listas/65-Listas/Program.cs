using System;
using System.Collections.Generic;

namespace _65_Listas
{
    class Program
    {
        static void Main()
        {
            /* ***** Listas ***** */
            // La lista es el tipo de coleccion mas ampliamente usado en c#
            // por su versatilidad, simplicidad y su potencia

            // List<T>
            // La clase List pertenece a System.Collection.Generic;
            Console.WriteLine("***** Ejemplo 1 - Creacion de listas instanciando la clase List *****");
            List<int> numbers = new List<int>();
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(10);
            // numbers.Add("Mark"); // No se puede agregar otro tipo de dato diferente al definido en la creacion de la coleccion en este caso no se pude agregar un string a una lista de int
            foreach (var item in numbers)
            {
                Console.WriteLine($"Value to item => {item}");
            }

            Console.WriteLine("\n");
            Console.WriteLine("***** Ejemplo 2 - Creacion de listas de tipo implicito *****");

            List<int> numbers1 = new List<int>();
            numbers1.Add(100);
            numbers1.Add(200);
            numbers1.Add(300);

            var cities = new List<string>();
            cities.Add("Lima");
            cities.Add("Valencia");
            cities.Add("Buenos Aires");
            foreach (var item in cities)
            {
                Console.WriteLine($"City => {item}");
            }

            Console.WriteLine("\n");

            List<string> countries = new List<string>()
            {
                "Brasil",
                "Bolivia",
                "Colombia"
            };

            foreach (var item in countries)
            {
                Console.WriteLine($"Country => {item}");
            }

            Console.WriteLine("\n");
            Console.WriteLine("***** Ejemplo 3 - Creacion de listas a partir de objetos *****");

            // List<Customer> customer = new List<Customer>()
            var customer = new List<Customer>();
            customer.Add(new Customer() { ID = 1, Name = "Mark" });
            customer.Add(new Customer() { ID = 2, Name = "Dave" });


            List<int> valores = new List<int>() { 2, 4, 6, 8, 10 };
            //Console.WriteLine($"valores[0] => {valores[0]}");
            //Console.WriteLine($"valores[1] => {valores[1]}");
            //Console.WriteLine($"valores[2] => {valores[2]}");
            //Console.WriteLine($"valores[3] => {valores[3]}");
            //Console.WriteLine($"valores[4] => {valores[4]}");
            var inc = 0;
            foreach (var item in valores)
            {
                Console.WriteLine($"Foreach loop -> Valores[{inc}] => {item}");
                inc++;
            }
            Console.WriteLine("\n");
            for (int i = 0; i < valores.Count; i++)
            {
                Console.WriteLine($"For loop -> Valores[{i}] => {valores[i]}");
            }

            Console.WriteLine("\n");
            Console.WriteLine("***** Ejemplo 4 - Insertar valores en listas *****");

            List<int> valores1 = new List<int>() { 2, 4, 6, 8, 10 };
            valores1.Insert(5,12);
            var increment = 0;
            foreach (var item in valores1)
            {
                Console.WriteLine($"Foreach loop -> Valores1[{increment}] => {item}");
                increment++;
            }

            Console.WriteLine("\n");
            Console.WriteLine("***** Ejemplo 4 - Eliminar valores en listas *****");

            List<int> valores2 = new List<int>() { 2, 4, 6, 8, 10 };
            // valores2.RemoveAt(0); // Elimina elementos por su inidice
            // valores2.Remove(8); // Elimina el elemento que se encuentre con ese valor

            // valores2.RemoveAt(valores2.Count - 1); // Elimina el ultimo valor de la lista con RemoveAt
            // valores2.RemoveAt(valores2.Count - valores2.Count); // Elimina el primer elemento de la lista con RemoveAt

            valores2.Remove(valores2[valores2.Count - 1]); // Elimina el ultimo valor de la lista con Remove
            valores2.Remove(valores2[valores2.Count - valores2.Count]); // Elimina el primer elemento de la lista con Remove

            var increment1 = 0;
            foreach (var item in valores2)
            {
                Console.WriteLine($"Foreach loop -> Valores2[{increment1}] => {item}");
                increment1++;
            }

            Console.WriteLine("\n");
            Console.WriteLine("***** Ejemplo 5 - Metodo Contains *****");
            List<int> valores3 = new List<int>() { 2, 4, 6, 8, 10 };
            Console.WriteLine(valores3.Contains(8)); // Valida si contiene el valor 8 => true
            Console.WriteLine(valores3.Contains(12)); // Valida si contiene el valor 12 => false


            var customer1 = new List<Customer>();
            customer1.Add(new Customer() { ID = 1, Name = "Billy" });
            customer1.Add(new Customer() { ID = 2, Name = "Jimmy" });
            customer1.Remove(new Customer() { ID = 1, Name = "Billy" }); // Esto no lo eliminara porque a pesar de que es el mismo objeto,  no es el mismo espacio en memoria
            foreach (var item in customer1)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine("\n");
            Customer customerData1 = new Customer() { ID = 1, Name = "Eddi" };
            Customer customerData2 = new Customer() { ID = 2, Name = "Amon" };
            customer1.Add(customerData1);
            customer1.Add(customerData2);
            customer1.Remove(customerData2); // Elimina exactamente su espacio en memoria por la instancia
            foreach (var item in customer1)
            {
                Console.WriteLine(item.Name);
            }

            Console.WriteLine("\n");
            Console.WriteLine("***** Ejemplo 6 - Recorrer y asignar items a la lista *****");
            Customer customers = new Customer();
            foreach (var item in customer1)
            {
                if (item.ID == 1)
                    customers = item;
            }
            //foreach (var item in customer)
            //{
            //    Console.WriteLine($"Value => {item}");
            //}
        }
    }

    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Customer()
        {

        }
    }
}
