using System;

namespace _36_IF
{
    class Program
    {
        static void Main()
        {
            string customerName = "Dave Martin";
            bool isJohn;

            if (customerName == "John Leven")
                isJohn = true;
            else
                isJohn = false;

            Console.WriteLine(isJohn);
            Console.WriteLine(customerName);

            if (customerName != "John Leven")
                isJohn = true;
            else
                isJohn = false;

            Console.WriteLine(isJohn);
            Console.WriteLine(customerName);

            isJohn = false;
            if (isJohn)
                Console.WriteLine($"isJohn verdadero: {isJohn}");
            else
                Console.WriteLine($"isJohn falso: {!isJohn}");


            int x = 15;
            int y = 30;

            if(x > y)
            {
                Console.WriteLine("x es mayor a y");
                Console.WriteLine("Ademas podemos tener mas de una linea");
                Console.WriteLine("y mas de dos");
            }
            else
            {
                Console.WriteLine("x no es mayor a y");
                Console.WriteLine("Ademas podemos tener aca tambien mas de una linea");
                Console.WriteLine("y tambien mas de dos");
            }



            // Operador ternario

            string z = (x > y) ? "x es mayor a y" : "y es mayor a x";
            Console.WriteLine(z);


        }
    }
}
