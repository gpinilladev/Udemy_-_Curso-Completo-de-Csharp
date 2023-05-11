32 - VARIABLES DE TIPO IMPLICITO

En las primeras lecciones de este curso dijimos que en C# las variables deben ser declaradas con su tipo de datos. Justamente porque estamos haciendo explicito cual es el tipo de la variable:

    int i = 100;

Una alternativa que C# nos ofrece es la de utilizar la palabra clave var para declarar variables adentro de metodo sin la necesidad de explicitar cual es el tipo de datos de la variable. Esto es lo que se conoce como variables de tipo implicito, en este tipo de declaraciones el compilador inferira cual es el tipo de la variable segun la expresion de la derecha del signo igual:

    var x = 100;
    var y = i + 20;

En el ejemplo la variable x compilara como un entero, lo mismo que la variable y que tambien compilara entero porque el resultado de la expresion a la derecha del signo igual es un entero.

EL uso de la palabra clave var no se reduce a tipos de datos primitivos, sino que tambien puede ser usado con strings, datetime y con cualquier tipo de datos definido por el usuario, es decir, para instanciar cualquier clase que hayamos creado, var no tiene ninguna limitacion en ese sentido:

    var y = i + 20;
    var s = "Hello world!";
    var car = new Car();

var puede ser utilizado para cualquier tipo de variables, o mejor dicho, para todo el espectro de tipos de datos que C# ofrece.

* CONSIDERACIONES

Algunas consideraciones a tener en cuenta con variables de tipo implicito son:

    - DEBEN ser inicializadas: Las variables de tipo implicito deben ser incializadas lo cual es logico si tenemos en cuenta que el tipo de la variable es inferido segun el valor con el cual es inicializado. Por lo tanto esto es obligatorio. Deben ser inicializadas.

    - NO pueden ser usados como parametros en funciones: Tampoco las variables var no puden ser usadas como parametros de funciones siempre que en la firma de una funcion o de un metodo definimos una variable, debemos utilizar el tipo de datos que esa variable tiene.

    - SI pueden ser utlizadas en for y foreach loop: Si puede ser usada en estos loops.

