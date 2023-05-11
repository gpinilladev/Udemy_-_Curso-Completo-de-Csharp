39 - FOR

En C# el loop for no es distinto a como funciona en otros lenguajes de programacion. La palabra clave FOR designa el comienzo del loop, la idea de la estructura FOR es que el bloque de codigo se ejecute repetidas veces hasta que la condicion especificada devuelva falso.

Estructura del FOR:

    for (initializer; condition; iterator)
    {
        // Code block
    }

Contiene tres secciones separadas po punto y coma, el initializer o el inicializador es utilizado para inicializar la variable que sera local dentro del loop y no sera accesible por fuera del loop. 

La condicion es una expresion booleanea que devolvera veradero o falso ser evaluada, si la evaluacion de la expresion es verdadera, entonces el bloque de codigo del FOR sera ejecutado otra vez, si es falsa, entonces no se ejecutara de nuevo el bloque de codigo FOR y las iteraciones se daran por terminadas, por lo que la secuencia saldra del loop.

Y por ultimo el iterator o iterador que define el incremento o decremento de la variable del loop que inicializamos en initializer.

Este es entonces un ejemplo de una estructura FOR:

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"Value: {i}");
    }

En el inicializador tenemos la declaracion e inicializacion de una variable llamada i de tipo int que tiene un valor inicial igual a cero 0. En la segunda seccion, aparece una expresion simple que simplemente verifica si el valor de la variable i es menor a 10, si esta condicion es verdadera, entonces el bloque de codigo sera ejecutado, una vez ejecutado el bloque de codigo, el proceso continuara con la tercera seccion del FOR que es el iterador i++ que es una sentencia incremental, como ya vimos en los operadores, que aumentara el valor de la variable i en 1, ahora el proceso verificará la expresion condicional y repetira el proceso hasta que la expresion condicional devuelva falso.

En el anterior ejemplo puntualmente, el bloque de codigo se ejecutara 10 veces, del 0 al 9 para la variable i. Si el bloque de codigo contiene una sola sentencia como en este caso, entonces no seria necesario utilizar las llaves, tal como veiamos para el IF/ELSE, asi:

    for (int i = 0; i < 10; i++)
        Console.WriteLine($"Value: {i}");

