using System;
using _18_Clases_Practico;
using MySecondNamespace;
namespace _18_Clases_Practico
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.FirstName = "Tony";
            customer1.LastName = "Soprano";
            Console.WriteLine(customer1.GetFullName());

            Customer customer2 = new Customer("Malkovich");
            Console.WriteLine(customer2.GetFullName());
            customer2.FirstName = "John";
            Console.WriteLine(customer2.GetFullName());

            Customer customer3 = new Customer("Mario", "Puzo");
            Console.WriteLine(customer3.GetFullName());

            Product product = new Product();
            Console.WriteLine(product.GetCustomer());
        }
    }

    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public Customer() {}

        public Customer(string lastName)
        {
            this.LastName = lastName;
        }

        public Customer(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string GetFullName()
        {
            return this.LastName + ", " + this.FirstName;
        }
    }
}

namespace MySecondNamespace
{
    class Product
    {
        public string GetCustomer()
        {
            Customer customer = new Customer("CustomerProduct");
            return customer.GetFullName();
        }
    }
}