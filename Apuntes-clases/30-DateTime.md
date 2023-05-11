30 - DATETIME

Para trabajar con fechas y tiempos en C# es necesario crear una instancia de la clase DateTime, utilizando la palabra clave new como hariamos con cualquier otra clase:

    DateTime dt = new DateTime();

El menos valor posible que una variable DateTime puede tener es la de el primero de enero del año 1 a la media noche:

    MinValue: 01/01/0001 00:00:00

Este es ademas el valor por defecto de una variable DateTime cuando ha sido inicializado sin parametros, por lo que en el ejemplo anterio, la variable dt que hemos inicializado tendra este valor (01/01/0001 00:00:00) en ese momento de la ejecucion.

El valor maximo posible de una variable DateTime es de el 31 de diciembre del 9999 un segundo antes de media noche:

    MaxValue: 12/31/9999 11:59:59

Es importante tener presentes estos valores por defecto, porque nos seran muy utiles a la hora de programar en C# y pronto veran porque.

DateTime como muchas otras clases o estructuras de C#, ofrece varias posibilidades de inicializacion, o lo que es lo mismo, tiene varios constructores que podemos elegir segun como necesitemos que nuestra fecha sea inicializada. 

En principio puede usarse con un constructor sin parametros, en cuyo caso, como deciamos, tendra por defecto el valor minimo posible del DateTime:

    DateTime dt = new DateTime(); // MinValue: 01/01/0001 00:00:00

Tambien podemos asignar año, mes y dia a nuestra fecha para inicializar directamente en el dia en que necesitamos:

    DateTime dt2 = new DateTime(2020, 12, 31); // 

Y ademas del año, mes y dia, podriamos tambien agregar el componente del tiempo y pasar por parametros, horas minutos y segundos a nuestra fecha:

    DateTime dt3 = new DateTime(2020, 12, 31, 5, 10, 20); // 

* DATETIME - STATIC FIELDS

Otra de las particularidades del tipo de datos DateTime es que incluye campos y propiedades estaticos que podemos utilizar sin la necesidad de crear un objeto.

Estos elementos son cruciales a la hora de trabajar con fechas porque nos dan la posibilidad de tener valores de referencia para comparar con los valores de nuestras varaiables.

Algunos ejemplos de estos campoes estaticos son, por ejemplo:

* DateTime.Now, que hace referencia a la fecha de hoy y a esta precisa hora y momento en el que se invoca el field:

    DateTime currentDate = DateTime.Now; // 

* Luego tenemos DateTime.Today, que hace referencia al dia de hoy:

    DateTime todaysDate = DateTime.Today; // 

* Tambien tenemos DateTime.MaxValue, que es como deciamos el valor maximo posible de los DateTime:

    DateTime maxDateTime = DateTime.MaxValue; // 

* Y tambien tenemos el valor minimo posible que puede ser retornado por DateTime.MinValue:

    DateTime minDateTime = DateTime.MinValue; // 



* TIMESPAN

Otra estructura relacionada con DateTime es TimeSpan, que representa tiempo en dias, horas, minutos, segundos y milisegundos. 
TimeSpan es sumamente util para cuando necesitamos realizar operaciones con fecha que agreguen o remuevan un valor de tiempo determinado.

- Supongamos que tenemos un DateTime con el valor:

    DateTime dt = new DateTime(2020, 08, 18);

- Ahora supongamos que tenemos un TimeSpan con el valor que no es otra cosa mas que una medida de tiempo con el valor de 25 horas, 20 minutos y 55 segundos:

    TImeSpan ts = new TimeSpan(25, 20, 55);


- Ahora, agreguemos el TimeSpan a nuestra fecha inial utilizando el metodo Add() del objeto DateTime:

    DateTime dt = new DateTime(2020, 08, 18);
    TImeSpan ts = new TimeSpan(25, 20, 55);
    DateTime newDate = dt.Add(ts);

El metodo Add() sirve exclusivamente para este proposito porque recibe por parametros valores de tipo TimeSpan. El valor que resultante sera una nueva fecha que almacenaremos en otra variable llamada newDate.

Si quisieramos imprimir el valor de esta variable, ahora la fecha seria el 19/08/2020 a la 1:20:55 a.m.:

    DateTime dt = new DateTime(2020, 08, 18);
    TImeSpan ts = new TimeSpan(25, 20, 55);
    DateTime newDate = dt.Add(ts);

    Console.WriteLine(newDate); // 19/08/2020 1:20:55 am

Este es el resultado de agregar un TimeSpan o un valor de tiempo a la fecha original.

Otro de los usos mas importantes de TimeSpan, es que es el resultado de restar dos fechas. Si cuando restamos una fecha con otra y el resultado que obtenemos es un valor de tiempo y por lo tanto ese valor de tiempo se almacena en variables de tipo TimeSpan. Es decir, que cuando queremos comparar cual es la diferencia entre dos fechas, el resultado sera siempre un TimeSpan y tiene sentido que asi sea, porque esta es la unidad de tiempo. 

Entonces supongamos que tenemos la misma fecha de antes y otra fecha, una fecha por delante de esa fecha inicial, asi:

    DateTime dt1 = new DateTime(2020, 08, 18);
    DateTime dt2 = new DateTime(2021, 05, 07);

Si a la segunda fecha que es la mayor le restamos la primera a traves del metodo Subtract() de el objeto DateTime, asi: 

    DateTime dt1 = new DateTime(2020, 08, 18);
    DateTime dt2 = new DateTime(2021, 05, 07);
    TimeSpan ts = dt2.Subtract(dt1);

Entonces obtenedremos un TimeSpan cuyo resultado sera el siguiente:

    DateTime dt1 = new DateTime(2020, 08, 18);
    DateTime dt2 = new DateTime(2021, 05, 07);
    TimeSpan ts = dt2.Subtract(dt1);
    Console.WriteLine(ts); // 262.00:00:00


* DATETIME OPERATORS

Cuando hablamos de tipos de datos, dijimos que cada tipo de datos reescribe los operadores a su manera. Es decir, que no es lo mismo aplicar el operador de suma + a dos valores enteros que a dos cadenas de texto. De la misma manera, la estructura de los DateTime sobreescribe los operadores para que funcionen de una manera que tenga sentido para fechas. Veamos un ejemplo:

- Supongamos que tenemos algunos valores, tenemos dos variables de tipo fecha y una de tipo TimeSpan:

    DateTime dt1 = new DateTime(2020, 08, 18);
    DateTime dt2 = new DateTime(2021, 05, 07, 5, 10, 20);
    TimeSpan ts = new TimeSpan(10, 5, 15,50);
    
Si operamos un poco entre ellas, supongamos que primero las sumamos, el resultado seria este:

    DateTime dt1 = new DateTime(2020, 08, 18);
    DateTime dt2 = new DateTime(2021, 05, 07, 5, 10, 20);
    TimeSpan ts = new TimeSpan(10, 5, 15,50);
    Console.WriteLine(dt2 + ts); // 17/05/21 10:26:10 am <-- Resultado

Fijense como en este caso a la variable llamada dt2 le agregamos el TimeSpan que es una diferencia casi que de 10 dias.
Como vimos recien, si a dt2 le restamos dt, es decir, si hacemos una diferencia entre las dos fechas, entonces obtenemos un TimeSpan:

    DateTime dt1 = new DateTime(2020, 08, 18);
    DateTime dt2 = new DateTime(2021, 05, 07, 5, 10, 20);
    TimeSpan ts = new TimeSpan(10, 5, 15,50);
    Console.WriteLine(dt2 - dt); // 262.05:20:20

Tambien podemos igualar fechas, es decir, con expresiones podemos preguntar si las fechas son iguales o son distintas, asi:

    DateTime dt1 = new DateTime(2020, 08, 18);
    DateTime dt2 = new DateTime(2021, 05, 07, 5, 10, 20);
    TimeSpan ts = new TimeSpan(10, 5, 15,50);

    Console.WriteLine(dt2 + ts); // 17/05/21 10:26:10 am <-- Resultado
    Console.WriteLine(dt2 - dt); // 262.05:20:20 <-- Resultado
    Console.WriteLine(dt2 == dt); // False <-- Resultado

En este caso el resultado sera falso porque obviamente las fechas no son iguales, lo mismo como decia, podemos preguntar sin son distintas y tambien podemos utilizar los operadores de comparacion, mayor o menor:

    DateTime dt1 = new DateTime(2020, 08, 18);
    DateTime dt2 = new DateTime(2021, 05, 07, 5, 10, 20);
    TimeSpan ts = new TimeSpan(10, 5, 15,50);

    Console.WriteLine(dt2 + ts); // 17/05/21 10:26:10 am <-- Resultado
    Console.WriteLine(dt2 - dt); // 262.05:20:20 <-- Resultado
    Console.WriteLine(dt2 == dt); // False <-- Resultado
    Console.WriteLine(dt2 != dt); // True <-- Resultado
    Console.WriteLine(dt2 > dt); // False <-- Resultado
    Console.WriteLine(dt2 < dt); // True <-- Resultado

* DATETIME TO STRING

Ademas de los operadores, DateTime nos ofrece una serie de metodos para convertir las fechas a cadenas de texto utilizando diversos formatos segun la informacion que necesitemos mostrar.

* El primero el metodo ToString convierte la fecha a un valor String segun el formato especificado por la cultura, incluye fecha y hora. 
* El segundo metodo, fijense que es distinto a ToShortDateString, excluye el factor de tiempo y solo mostrara la fecha en formato numerico, es decir, numero para dia, mes y año. 
* El tercer metodo ToShortTimeString, solo imprime el factor de tiempo olvidandose por completo de la fecha
* El cuarto metodo ToLongDateString, Tampoco aparecera el tiempo, solo la fecha, pero tendra un formato mucho mas amplio con el dia, el mes completo y el numero del año.
* Finalmente tenemos el quinto metodo ToLongTimeString, imprime solo el tiempo, incluyendo hora, minutos y segundos.

    METHOD                  DESCRIPTION                         EXAMPLE

    ToString            Depends on selected culture     18/08/2020 12:00:00 am
    ToShortDateString   M/d/yyyy                        18/08/2020
    ToShortTimeString   h:mm:ss                         12:00 am
    ToLongDateString    dddd, MMMM d, yyyy              Tuesday, 18 August 2020
    ToLongTimeString    h:mm:ss tt                      12:00:00 am