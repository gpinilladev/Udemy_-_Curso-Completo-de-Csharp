using System;
using System.Collections.Generic;

namespace _70_For_Each
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("\n");
            /* ***** Foreach ***** */
            // Foreach funciona de una manera similar al for, solo que opera directamente sobre colecciones de objetos, instancias arrays u otras tipos de listas.
            // Asi es como se declara e inicializa:
            // ArrayList list = new ArrayList();
            // Y asi es como se agregan elementos:
            // list.Add("John Dow");
            // list.Add("Jane Doe");
            // list.Add("Someone else");
            // Y asi es como se usa el foreach para recorrer listas
            // foreach (string name in list)
            // {
            //   Console.WriteLine(name);
            // }

            Console.WriteLine("***** Ejemplo 1 - Definicion *****");
            char[] anyWord = { 'c', 'o', 'd', 'e', 'r', ' ', 'c', 'a', 'v', 'e' };
            foreach (var item in anyWord)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n");
            Console.WriteLine("***** Ejemplo 2 - Uso en listas - recorrido *****");
            var numbers = new List<int>() { 2, 6, 8, 12, 20, 40 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\n");
            Console.WriteLine("***** Ejemplo 3 - Alteracion de datos *****");
            var numbers2 = new List<int>() { 2, 6, 8, 12, 20, 40 };
            var sum = 0;
            foreach (int number in numbers2)
            {
                sum += number;
            }
            Console.WriteLine(sum);

            Console.WriteLine("\n");
            Console.WriteLine("***** Ejemplo 4 - Recorriendo listas de objetos *****");
            var numbers3 = new List<int>() { 2, 6, 8, 12, 20, 40 };
            List<Customer> customer = new List<Customer>();
            customer.Add(new Customer() { ID = 1, Name = "Marty Friedman" });
            customer.Add(new Customer() { ID = 2, Name = "David Ellefson" });
            customer.Add(new Customer() { ID = 3, Name = "Nick Menza" });
            customer.Add(new Customer() { ID = 4, Name = "Dave Mustaine" });
            // var sum = 0;
            foreach (Customer cus in customer)
            {
                Console.WriteLine($"{cus.ID}: {cus.Name}");
            }
            

        }
    }
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Customer()
        {

        }
    }
}
