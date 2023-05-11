using System;
using _18_1_Clases_Practico;
using ProductNamespace;

namespace _18_1_Clases_Practico
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("\n-------- Customer 1 ---------\n");
            Customer customer1 = new Customer();
            customer1.FirstName = "German";
            customer1.LastName = "Pinilla";
            Console.WriteLine(customer1.getFullName());

            Console.WriteLine("\n-------- Customer 2 ---------\n");
            Customer customer2 = new Customer("Cecilia");
            Console.WriteLine(customer2.getFullName());
            customer2.LastName = "Rubiano";
            Console.WriteLine(customer2.getFullName());

            Console.WriteLine("\n-------- Customer 3 ---------\n");
            Customer customer3 = new Customer("Willam", "Rubiano");
            Console.WriteLine(customer3.getFullName());

            Console.WriteLine("\n-------- Customer 4 ---------\n");
            Product product = new Product();
            Console.WriteLine(product.getDataCustomer());

            Console.WriteLine("\n-------- Customer 5 ---------\n");
            Customer customer4 = new Customer("Roberto", "Rodriguez");
            Console.WriteLine(customer4.getFullName());
        }
    }


    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Customer()
        {

        }

        public Customer(string firstName)
        {
            FirstName = firstName;
        }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string getFullName()
        {
            return "Nombre: " + (FirstName != null ? FirstName : " - Nombre vacio! - ") + "\n" + "Apellido: " + (LastName != null ? LastName : " - Apellido Vacio! - ");
        }

    }
}

namespace ProductNamespace
{
    class Product
    {
        public string getDataCustomer()
        {
            Customer customer = new Customer("John", "Doe");
            return customer.getFullName();
        }
    }
}