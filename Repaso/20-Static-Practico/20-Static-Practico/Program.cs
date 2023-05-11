using System;
namespace _20_Static_Practico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ********** 1 ********** \n");

            CustomerNoStatic customer1 = new CustomerNoStatic();
            string fullName = customer1.GetPrettyFormatName("German", "Pinilla");
            Console.WriteLine(fullName);

            Console.WriteLine("\n ********** 2 ********** \n");

            string playerName = CustomerStatic.GetPrettyFormatName("James", "Rodriguez");
            Console.WriteLine(playerName);

            Console.WriteLine("\n ********** 3 ********** \n");

            CustomerNoStatic customer2 = new CustomerNoStatic();
            customer2.Street = "Avenida Siempre Viva";
            customer2.Number = 123;
            string fullAddress = customer2.GetAddress();
            Console.WriteLine(fullAddress);
        }
    }

    static class CustomerStatic
    {
        public static int Id { get; set; }
        public static string Street { get; set; }
        public static int Number { get; set; }

        public static string GetPrettyFormatName(string firstName, string lastName)
        {
            return "Nombre: " + (firstName != null ? firstName : " - Nombre vacio! - ") + "\n" + "Apellido: " + (lastName != null ? lastName : " - Apellido vacio! -");
        }

        public static string GetAddress()
        {
            // return Street + " " + Number;
            return "Direccion: " + Street + " " + Number;
        }
    }

    class CustomerNoStatic
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }

        public string GetPrettyFormatName(string firstName, string lastName)
        {
            // return lastName + ", " + firstName;
            return "Nombre: " + (firstName != null ? firstName : " - Nombre vacio! - ") + "\n" + "Apellido: " + (lastName != null ? lastName : " - Apellido vacio! -");
        }

        public string GetAddress()
        {
            // return Street + " " + Number;
            return "Direccion: " + Street + " " + Number;
        }
    }
}