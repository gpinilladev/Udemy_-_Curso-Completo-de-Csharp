using System;

namespace _20_Static
{
    class Program
    {
        static void Main()
        {
            // No se puede instanciar un metodo estatico
            // Customer customer = new CustomerStatic();
            // Console.WriteLine(customer.GetPrettyFormatName("German", "Pinilla"));
            Console.WriteLine("\n ********** 1 ********** \n");
            Console.WriteLine(CustomerStatic.GetPrettyFormatName("German", "Pinilla"));

            Console.WriteLine("\n ********** 2 ********** \n");
            // Una clase no estatica puede referenciar metodos estaticos pero no puede definirlos en instancia de clase
            Console.WriteLine(CustomerNoStatic.GetPrettyFormatName("German", "Pinilla"));

            Console.WriteLine("\n ********** 3 ********** \n");
            // Una clase no estatica, no tendra visibles las propiedades y metodos estaticos cuando se cree una nueva instancia
            CustomerNoStatic customer = new CustomerNoStatic();
            customer.Street = "Avenida Simpre Viva";
            customer.Number = 123;
            Console.WriteLine(customer.GetAddress());

        }
    }

    static class CustomerStatic
    {
        public static int Id { get; set; }
        public static string Street { get; set; }
        public static int Number { get; set; }

        public static string GetPrettyFormatName(string firstName, string lastName)
        {
            return "👨🏽‍💻 Nombre: " + (firstName != null ? firstName : " - Nombre vacio! - ") + "\n" + "👨🏽‍💻 Apellido: " + (lastName != null ? lastName : " - Apellido vacio! -");
        }

        public static string GetAddress()
        {
            return "🏘 Dirección: " + Street + " " + Number;
        }

    }

    class CustomerNoStatic
    {
        public static int Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }

        public static string GetPrettyFormatName(string firstName, string lastName)
        {
            return "👨🏽‍💻 Nombre: " + (firstName != null ? firstName : " - Nombre vacio! - ") + "\n" + "👨🏽‍💻 Apellido: " + (lastName != null ? lastName : " - Apellido vacio! -");
        }

        public string GetAddress()
        {
            return "🏘 Dirección: " + Street + " " + Number;
        }

    }
}
