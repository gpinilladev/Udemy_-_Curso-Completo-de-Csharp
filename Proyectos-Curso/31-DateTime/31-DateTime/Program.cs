using System;
namespace _31_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ********** DateTime ********** */
            // La clase DateTime nos permite generar fechas y se intancia como cualquier otra clase en C#
            DateTime dt = new DateTime(); // Si no pasamos parametros, por defecto nos tomara la fecha de 1/1/0001 12:00:00 AM
            // Para poder imprimir el valor pasamos el metodo .ToString() para obtener la fecha como texto y poderla imprimir
            Console.WriteLine($"Fecha por defecto sin parametros: {dt.ToString()}"); // El resultado sera => 1/1/0001 12:00:00 AM

            // Podemos tambien inicializar la clase pasandole parametros año, mes y dia DateTime dt = new DateTime(año, mes, dia);
            DateTime dt1 = new DateTime(2022, 5, 3);
            Console.WriteLine($"Fecha con año, mes, dia: {dt1.ToString()}");

            // Podemos tambien inicializar la clase pasandole no solo los parametros de año, mes y dia, tambien podemos pasarle horas, minutos y segundos a la clase
            DateTime dt2 = new DateTime(2022, 12, 31, 15, 10, 20);
            Console.WriteLine($"Fecha con año, mes, dia, hora, minuto, segundo: {dt2.ToString()}");

            // Otra particularidad de la clase DateTime, es que incluye campos y propiedades estaticas sin la necesidad de crear un objeto
            // Fecha de ahora mismo
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"Fecha ahora mismo: {currentDate.ToString()}");

            // Fecha de hoy
            DateTime todaysDate = DateTime.Today;
            Console.WriteLine($"Fecha de hoy: {todaysDate.ToString()}");

            // Fecha minima de DateTime
            DateTime minDateTime = DateTime.MinValue;
            Console.WriteLine($"Fecha minima DateTime: {minDateTime.ToString()}");

            // Fecha maxima DateTime
            DateTime maxDateTime = DateTime.MaxValue;
            Console.WriteLine($"Fecha maxima DateTime: {maxDateTime.ToString()}");

            // Dias de un mes y año especifico
            int daysInMonth = DateTime.DaysInMonth(2023, 4);
            Console.WriteLine($"Dias en el mes 04/2023: { daysInMonth }");

            // Determina si un año en especifico es bisiesto
            bool isLeapYear = DateTime.IsLeapYear(2023);
            System.Console.WriteLine($"Es bisiesto el año?: {isLeapYear}");

            Console.WriteLine("\n********************** TimeSpan **********************\n");

            // Otra estructura es TIMESPAN que nos represents tiempo en dias, horas, minutos, segundos y milisegundos

            DateTime initialDt = new DateTime(2020, 08, 18);
            Console.WriteLine(initialDt.ToString());

            // Puedo agregar fechas con addDays()
            DateTime addDays = initialDt.AddDays(10);
            System.Console.WriteLine($"Se agregan 10 dias a la fecha inicial: {addDays}");

            // Puedo agregar meses a la fecha con AddMonths()
            DateTime addMonths = initialDt.AddMonths(3);
            System.Console.WriteLine($"Se agregan 3 meses a la fecha inicial: {addMonths}");

            // Puedo agregar años a la fecha con AddYears()
            DateTime addYears = initialDt.AddYears(2);
            System.Console.WriteLine($"Se agregan 2 años a la fecha inicial: {addYears}");

            // Puedo agregar horas a la fecha con AddHours()
            DateTime addHours = initialDt.AddHours(10);
            System.Console.WriteLine($"Se 10 horas a la fecha inicial: {addHours}");

            // Puedo agregar minutos a la fecha con AddMinutes()
            DateTime addMinutes = initialDt.AddMinutes(30);
            System.Console.WriteLine($"Se agregan 30 minutos a la fecha inicial: {addMinutes}");

            // Puedo agregar segundos a la fecha con AddSeconds()
            DateTime addSeconds = initialDt.AddSeconds(1800);
            System.Console.WriteLine($"Se agregan 1800 segundos a la fecha inicial: {addSeconds}");

            // Obtener dia de la fecha
            int dayDate = initialDt.Day;
            System.Console.WriteLine($"Dia de la fecha inicial: {dayDate}");

            // Obtener mes de la fecha
            int monthDate = initialDt.Month;
            System.Console.WriteLine($"Mes de la fecha inicial: {monthDate}");

            // Obtener año de la fecha
            int yearDate = initialDt.Year;
            System.Console.WriteLine($"Año de la fecha inicial: {yearDate}");

            // Obtener dia de la semana de la fecha
            var dayWeekDate = initialDt.DayOfWeek;
            System.Console.WriteLine($"Dia se la semana de la fecha inicial: {dayWeekDate}");

            // Obtener dia del año de la fecha
            int dayYearDate = initialDt.DayOfYear;
            System.Console.WriteLine($"Dia del año de la fecha inicial: {dayYearDate}");

            TimeSpan newTs = new TimeSpan(25, 20, 55);
            Console.WriteLine(newTs.ToString());

            DateTime newDate = initialDt.Add(newTs);
            Console.WriteLine(newDate.ToString());

            Console.WriteLine("\n --------------------------- \n");

            // DateTime Operators
            // Tambien podemos escribir operaciones entre fechas
            DateTime dtOp1 = new DateTime(2020, 08, 18);
            DateTime dtOp2 = new DateTime(2021, 05, 07, 5, 10, 20);
            TimeSpan tsOp1 = new TimeSpan(10, 5, 15, 50);

            // Podemos restar deos fechas y obtendremos un TimeSpan como resultado
            TimeSpan diferenceTime = dtOp2 - dtOp1;
            Console.WriteLine($"dtOp2 - dtOp1 = { diferenceTime }");

            // Tambien podemos agregarle ese TimeSpan a una fecha
            dtOp1 = dtOp1.Add(diferenceTime);
            Console.WriteLine($"dtOp1.Add({ diferenceTime }) = {dtOp1}");

            // Podemos restarle un TimeSpan a una fecha
            dtOp1 = dtOp1.Subtract(diferenceTime);
            Console.WriteLine($"dtOp1.Subtract({diferenceTime}) = {dtOp1}");

            // Algunas operaciones
            Console.WriteLine($"Fecha 1: {dtOp1.ToString()}");
            Console.WriteLine($"Fecha 2: {dtOp2.ToString()}");
            Console.WriteLine($"Fecha 2 + 10 dias, 5 horas, 15 minutos y 50 segundos: {dtOp2 + tsOp1}");
            Console.WriteLine($"Fecha 2 - fecha 1: {dtOp2 - dtOp1}");
            Console.WriteLine($"Fecha 2 == Fecha 1: {dtOp2 == dtOp1}");
            Console.WriteLine($"Fecha 2 != Fecha 1: {dtOp2 != dtOp1}");
            Console.WriteLine($"Fecha 2 > Fecha 1: {dtOp2 > dtOp1}");
            Console.WriteLine($"Fecha 2 < Fecha 1: {dtOp2 < dtOp1}");

            // currentDate = DateTime.Now;

            Console.WriteLine($"Current date normal format: { currentDate.ToString("d") }");
            Console.WriteLine($"Current date format (DD/MM/YYYY): { currentDate.ToString("dd/MM/yyyy") }");
            Console.WriteLine($"Current date format (dddd, dd MMMM yyyy): {currentDate.ToString("dddd, dd MMMM yyyy")}");
            Console.WriteLine($"Current date format (dd/MM/yyyy h:mm:ss tt): {currentDate.ToString("dd/MM/yyyy h:mm:ss tt")}");
            Console.WriteLine($"Current date format (HH:mm:ss): {currentDate.ToString("HH:mm:ss")}");
            Console.WriteLine($"Current date format (HH:mm tt): {currentDate.ToString("hh:mm tt")}");
            Console.WriteLine($"Current date format ToShortDateString: {currentDate.ToShortDateString()}");
            Console.WriteLine($"Current date format ToLongDateString: {currentDate.ToLongDateString()}");
            Console.WriteLine($"Current date format ToShortTimeString: {currentDate.ToShortTimeString()}");
            Console.WriteLine($"Current date format ToLongTimeString: {currentDate.ToLongTimeString()}");

        }
    }
}