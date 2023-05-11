43 - DO WHILE

El loop DO WHILE funciona de la misma manera que el WHILE excepto que en este caso el bloque de codigo al menos una vez porque la condicion se evalua recien al final. Recordemos como en el WHILE la condicion se evaluaba al principio y luego, si el resultado era verdadero se ejecutaba el bloque de codigo, pero claro que en este caso existe la posibilidad de que el resultado de la evaluacion sea falso y el bloque de codigo nunca se ejecute.

    do {
        // Code block
    } while (condition)

Esta es la unica diferencia que el DO WHILE propone, aqui la primera vez siempre se ejecutara el bloque de codigo y luego en base a la condicion habra o no iteraciones.

Igual que antes, el loop terminara cuando la condicion del while tenga un resultado falso.

Supongamos un ejemplo muy parecido al anterior:

    int i = 0;

    do {
        Console.WriteLine($"Value: {i}");
        i++;
    } while(i < 15);

Aqui tenemos un int inicializado en 0 cero luego tenemos el DO y adentro en el bloque de codigo se imprime en consola el valor de i y se incrementa ademas el valor de la variable. 

Como deciamos la primera vez esto va a suceder si o si y luego se evalua la condicion del while, aqui la condicion sera verdadera las primeras 15 veces luego sera falso y el loop finalizara.

