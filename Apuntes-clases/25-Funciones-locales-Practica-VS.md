using System;

namespace _25_Funciones_locales
{
    class Program
    {
        static void Main()
        {
            CustomerNoStatic customer = new CustomerNoStatic();
            customer.Street = "Avendida siempre viva";
            customer.Number = 123;
            customer.Gender = "M";
            Console.WriteLine(customer.GetPrettyFormatName("German", "Pinilla"));

            CustomerNoStatic customer1 = new CustomerNoStatic();
            customer1.Street = "Avendida siempre viva";
            customer1.Number = 123;
            customer1.Gender = "F";
            Console.WriteLine(customer1.GetPrettyFormatName("Andrea", "Bernal"));
        }
    }

    class CustomerNoStatic
    {
        public static int Id { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Gender { get; set; }

        public string GetPrettyFormatName(string firstName, string lastName)
        {
            string GetLastName()
            {
                if (Gender == "M")
                    return "Mr. ";
                else
                    return "Mrs. ";
            }
            return "👨🏽‍💻 Nombre: " + (firstName != null ? GetLastName() + firstName : " - Nombre vacio! - ") + "\n" + "👨🏽‍💻 Apellido: " + (lastName != null ? lastName : " - Apellido vacio! -");
        }

        public string GetAddress()
        {
            return "🏘 Dirección: " + Street + " " + Number;
        }

    }
}
