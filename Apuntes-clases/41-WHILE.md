41 - WHILE

C# ofrece el loop WHILE cuando necesitemos ejecutar repetidamente un bloque de codigo, mientras la evaluacion de la condicion sea verdadera. El loop WHILE comienza con la palabra clave while y debe incluir una expresion condicional booleana que devuelva verdadero o falso.

El loop ejecutara el bloque de codigo hasta tanto la expresion condicional sea falsa:

    while (condition)
    {
        // Code block
    }

A diferencia del FOR, en donde el inicializador y el incremento o decremento de la variable se escribe en la misma definicion de la sentencia, en el WHILE la inicializacion de la variable debe suceder antes de que el loop empiece y el incremento o decremento de la variable debe ocurrir adentro del loop.

    int i = 0;
    while (i < 20) 
    {
        Console.WriteLine($"Value: {i}");
        i++;
    }

Aqui el WHILE incluye una expresion que valida si el valor de la variable i es menor a 20, mientras esto sea verdadero, entonces se ejecutara el bloqued e codigo y la variable i sera incrementada, una vez mas se valida si la condicion es verdadera y si lo es, entonces se vuelve a ejecutar el bloque de codigo y asi se repite hasta que la condicion devuelva falso.

En el anterior ejemplo, el bloqued e codigo se ejecutara 20 veces entre valores de 0 y 19 para i.