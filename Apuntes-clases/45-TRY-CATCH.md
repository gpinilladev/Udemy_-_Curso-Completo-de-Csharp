45 - Try / Catch

Si bien ya hemos utilizado esta estructura de control antes y la explicamos brevemente, ahora seria interesante verla un poco mas en detalle. Cuando ejecutamos codigo en C# o en cualquier otro lenguaje de programacion, distintos tipos de errores pueden ocurrir:

    * Errores cometidos por el programador
    * Errores forzados por el usuario
    * Errores inesperados

Cuando un error ocurre en C#, en general la secuencia que habiamos programado se detendra y el sistema devolvera un error que en realidad se conoce como excepcion.

Para poder anticiparnos a estos errores y capturarlos en tiempo de ejecucion, contamos con la estructura TRY / CATCH:

    try {
        // Code of block to try
    } catch (condition) {
        // Block of code to handle errors
    } finally {
        // Block of code that always runs.
    }

La sentencia TRY permite definir un bloque de codigo que sera testeado por errores mientras es ejecutado. Cualquier error que ocurra dentro de el bloque de codigo del TRY, sera capturado por la instruccion CATCH, que a su vez define un bloque de codigo para ser ejecutado justamente cuando el error sea capturado, y por ultimo la instruccion finally es opcional, de hecho no la veran en la mayoria de los TRY / CATCH y sirve para definir codigo que si o si se ejecutara sin importar si un error ha sido capturado o no. Una vez que finalice el bloque de codigo del TRY, el FINALLY sera ejecutado.

Veamos un ejemplo clasico del uso de un TRY / CATCH:

    string name = "Mark";
    int number = int.Parse(name);

Aqui tenemos un string con una cadena de texto como cualquier otra y a continuacion una variable de tipo int y un intento por convertir ese string en un int.

El ejemplo es bastante tonto porque evidentemente esto va a dar un error, no se puede convertir esa cadena de texto en un numero entero. La forma de capturar el posible error que este codigo devolvera es envolviendolo con una estructura TRY/CATCH:

    try {
        
        string name = "Mark";
        int number = int.Parse(name);

    } catch (Exception e) {
        Console.WriteLine("Cannot parse that");
    } 

De este modo, cuando el error ocurra, se ejecutara el bloque de codigo que esta dentro del CATCH y luego la aplicacion seguira normalmente y no rompera las secuencias de codigo que le siguen. Si miras detenidamente, notaras que hay una variable local dentro del CATCH que es de tipo Exception, esta es una clase que forma parte de .NET Core y que contiene los detalles especificos del error que acaba de ocurrir. En el apartado practico de esta leccion, veremos que cosas contiene esta clase y como podemos aprovecharla.

Hasta ahora hemos visto excepciones que han sido automaticamente disparadas por .NET, pero ademas les quiero mostrar como disparar excepciones manualmente.

Una excepcion puede ser disparada manualmente, es decir, por el programador utilizando la palabra clave THROW:

    string name = "John";
    if (name != "John")
        throw new Exception("Name should be John");

En este sencillo ejemplo veremos el uso de THROW, que es igual de simple, hay una variable name de tipo string con el valor de John, y luego una condicion que evalua si el valor es de esa variable es distinto de John. Si el valor de name no es John, entonces se dispara manualmente un error. Esto es importante para cuando necesitemos, por ejemplo, que el proceso dete ga su ejecucion para mostrar determinado mensaje por pantalla.
