46 - TRY/CATCH - EXCEPCIONES

En C# las excepciones se representan con clases y ademas todas las excepciones heredan directa o inderectamente de la clase base System.Exception

El lenguaje contiene un amplio repertorio de excepciones disponibles segun lo especifico de la excepcion que necesitemos capturar. Repasemos ahora en una tabla cuales son algunas de las clases mas importantes que derivan de System.Exception.

System Exception

System.IO.IOException
System.IndexOutOfRangeException
System.NullReferenceException
System.DivideByZeroException

Agregue solo estas cuatro porque son ejemplos representativos, pero C# tiene como decia, una gran variedad de excepciones para elegir. Entre las que aparecen aqui tenemos:

    * System.IO.IOException - Que hace referencia a excepciones de tipo input / output que basicamente se utilizan para cuando estamos trabajando con archivos o directorios, si por ejemplo, intentamos leer en nuestro disco un archivo que no existe, entonces obtendremos una excepcion de tipo IOException 

    * System.IndexOutOfRangeException - Aparecera cuando intentemos acceder a una posicion que no existe en un array.

    * System.NullReferenceException - Aparecera cuando intentemos utilizar el valor de una variable nula.

    * System.DivideByZeroException - Com su nobre lo dice, ocurrira cuando el motor de .NET se encuentre con un intento de dividir por 0 cero.

Ademas de las excepciones ya disponibles en el lenguaje, siempre podremos crear nuestras propias excepciones simplemente creando una clase y haciendo que herede de System.Exception, pero por ahora dejemos la herencia para un poco mas adelante.

