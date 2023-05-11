35 - IF - OPERADOR TERNARIO

Ademas de la estructura IF/ELSE convencional en C#, podemod utilizar el operador ternario, que es basicamente un IF/ELSE clasico, pero en su forma mas comprimida posible:

    condition ? statement : statement2;

El operador ternario empieza con una condicion booleana tal cual lo haria un IF, si la evaluacion de esta condiocion es verdadera, entonces se ejecutara el primer statement que sigue al signo de pregunta, si en cambio la evaluacion de la condicion es falsa, entonces el segundo statement que esta despues de los dos puntos : es el que se ejecutara.

Este ejemplo nos servira para demostrar el uso del operador ternario:

    int x = 10, y = 5;
    string z = x > y ? "greater x" : "greater y";

Aqui tenemos dos variables numericas x e y, luego en el operador ternario aparece primero una condicion, x mayor a y y acontinuacion la primera sentencia devuelve una cadena de texto que especifica que x es mayor, y la segunda sentencia dice lo opuesto, que y es mayor. La forma en la que se lee esta condicion es, si x es mayor a y, entonces almacenar en la variable z la cadena "greater x", y si no, si x no es mayor y, entonces almacer en la variable z "greater y". 

Al ser equivalente al IF/ELSE tradicional tambien lo podriamos escribir de esta manera si quisieramos:

    if (x > y)
        z = "greater x";
    else 
        z = "greater y";

Fijese como ahorramos palabras utilizando el operador ternario.

Los operadotes ternarios asi como las estructuras IF convencionales, soportan anidados, o lo que es lo mismo decir que podemos agregar un operador ternario adentro de otro:

    int x = 10, y = 5;
    string z = x > y ? "x is greater than y" : x < y ? "y is greater than x" : x == y ? "x is equal to y" : "How did you get here?";

Aqui tenemos un ejemplo parecido al anterior, si prestamos atencion especial a las condiciones, tenemos primero la misma que antes, si x es mayor a y, entonces z tendra el valor de "x is greater than y", sino si x es menor a y, entonces z tendra el valor de "y is greater than x", pero si esta segunda condicion es falsa, entonces una nueva condicion sera evaluada, esta nueva condicion pregunta si x es igual a y, si esto es verdadero, entonces z tendra el valor de "x is equal to y", y sino entonces la ultima salida de este operador ternario es la cadena "How did you get here?", porque practicamente imposible que esta sea alcazada.

Como pueden ver un operador ternario puede ser tan complejo como sea necesario, lo importante aqui es que el codigo quede legible y que las condiciones tengan sentido para que el codigo quede limpio y se entienda facilmente.