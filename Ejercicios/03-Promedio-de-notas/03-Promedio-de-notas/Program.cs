using System;

namespace PromedioNotasApp {
    class PromedioNotas
    {
        static void Main()
        {
            Console.WriteLine("*********** Promedio de notas **********");

            Console.WriteLine("Ingrese la note del primer corte: ");
            double nota1;
            var validaNota1 = double.TryParse(Console.ReadLine()!, out nota1);

            Console.WriteLine("Ingrese la note del segundo corte: ");
            double nota2;
            var validaNota2 = double.TryParse(Console.ReadLine()!, out nota2);

            Console.WriteLine("Ingrese la note del tercer corte: ");
            double nota3;
            var validaNota3 = double.TryParse(Console.ReadLine()!, out nota3);

            if (validaNota1 && validaNota2 && validaNota3)
            {
                var notaPromedio = ((nota1 + nota2 + nota3) / 3);
                Console.WriteLine($"La nota promedio es:  {notaPromedio}");
            } else
                Console.WriteLine("Los valores de las notas deben ser numero con sus respectivas decimas (Ej: 4.5)");
        } 
    }
}