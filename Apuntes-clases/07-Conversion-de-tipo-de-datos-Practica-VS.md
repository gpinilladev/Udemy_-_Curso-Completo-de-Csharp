using System;
namespace _07_Conversion_de_tipo_de_datos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             - Tipos numericos integrados
                - byte
                - short
                - int
                - long
             - Tipos numericos de punto flotante
                - float
                - double
                - decimal
             - Boolean
                - bool
             - Char
                - char
             - String
                - string
             */
            // Conversion implicita
            byte firstNum = 100;
            int secondNumber = firstNum;
            Console.WriteLine(Separator("1"));
            Console.WriteLine(secondNumber);

            // Conversion implicita de un tipo de dato de mayor rango a menor rango
            // int numA = 100; Con 100 byte soporta su valor
            // int numA = 1000; Con 100 byte no soporta su valor y alamacena solamente lo que byte alcanza a almacenar como tipo de dato
            int numA = 1000;
            byte numB = (byte)numA;
            Console.WriteLine(Separator("2"));
            Console.WriteLine(numB);

            //string textNumber = "1234";
            //int number = int.Parse(textNumber);
            //// int number = Int32.Parse(textNumber);
            //Console.WriteLine(Separator("3"));
            //Console.WriteLine(number);

            try
            {
                string textNumber = "1234";
                int number = int.Parse(textNumber);
                // int number = Int32.Parse(textNumber);
                Console.WriteLine(Separator("3"));
                Console.WriteLine(number);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine(Separator("4"));
                Console.WriteLine("Something went wrong!");
            }


            // Tambien podemos usar la funcion int.tryParse la cual maneja una excepcion y es mas corta su definicion
            // tryParse(variable-a-convertir, out variable-en-la-que-se-almacenara-la-conversion)
            string txtValue = "1234";
            int numberValue;
            bool validCast = int.TryParse(txtValue, out numberValue); // Esta variable de tipo bool nos guardara si se pudo hacer la conversion o no (true ó false)
            Console.WriteLine(Separator("5"));
            Console.WriteLine(validCast);
            Console.WriteLine(Separator("6"));
            Console.WriteLine(numberValue);

            string numberString = "24543434534645456";
            long numberInt;
            bool validParse = long.TryParse(numberString, out numberInt);
            Console.WriteLine(validParse);
            Console.WriteLine(numberInt);

            // Tambien podemos usar el metodo convert con el cual podemos abreviar la sentencia de forma rapida
            string txtValueNumber = "1234";
            int valueNumber = Convert.ToInt32(txtValueNumber);
            Console.WriteLine(Separator("7"));
            Console.WriteLine(valueNumber);

            string newValueText = "1234";
            float newValueFloat = Convert.ToSingle(newValueText);
            Console.WriteLine(Separator("8"));
            Console.WriteLine(newValueFloat);

            string valueText = "1234";
            long longValueText = Convert.ToInt64(valueText);
            Console.WriteLine(Separator("9"));
            Console.WriteLine(longValueText);

            int newValueInt = 12345678;
            string valueToString = newValueInt.ToString();
            Console.WriteLine(Separator("10"));
            Console.WriteLine(valueToString);

            bool valid = true;
            string validString = valid.ToString();
            Console.WriteLine(Separator("11"));
            Console.WriteLine(validString);

            string textBool = "true";
            bool ok = Convert.ToBoolean(textBool);
            Console.WriteLine(Separator("12"));
            Console.WriteLine(ok);

        }

        public static string Separator(string tab)
        {
            return tab + ") ------------------------------------";
        }
    }
}