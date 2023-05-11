34 - IF / ELSE

Una de las estructuras de control mas importantes en todo el lenguaje de programacion es la sentencia IF. La capacidad de crear bloques condicionales es fundamental en el desarrollo de software, si ya has usado esta sentiencia en otros lenguajes, entonces podras comenzar a usarla en C# sin mucho preambulo porque su comportamiento es exactamente igual al de otros, aunque quizas la sintaxis cambie levemente.

La sentencia IF necesita de un resultado booleano que puede ser verdadero o falso, esto es lo que se conoce como condicion. En tiempo de ejecucion la condicion sera evaluada y si es verdadera entonces el bloque de codigo sera ejecutado, si la condicion es falsa entonces no sera ejecutado. De esta forma:

    if (condicion) 
    {
        // Code to run when condition == true
    }

Consideremos dos variables enteras con dos valores por defecto: 

    int x = 100, y = 200;
    if (x < y) 
    {
        Console.WriteLine("x is lesser than y");
    }

En este caso tenemos la condicion x menor a y, evidentemente cuando la condicion sea evaluada, su resultado sera verdadero y por lo tanto el  codigo que esta dentro del bloque IF sera ejecutado.

En este ejemplo la condicion es x mayor a y lo cual no es cierto como podemos ver claramente en la declaracion de las variables, por lo tanto, la evaluacion de la dara falso y el codigo no sera ejecutado, de esta forma:

    int x = 100, y = 200;
    if (x > y) 
    {
        Console.WriteLine("x is greater than y");
    }

Estas dos mismas sentencias IF tambien se pueden escribir asi:

    int x = 100, y = 200;
    if (x < y) 
        Console.WriteLine("x is lesser than y");
    
    if (x > y) 
        Console.WriteLine("x is greater than y");

La unica diferencia respecto a lo que vimos recien es que no hay llaves despues de las condiciones de los IFS, esto es porque no necesitamos usar las llaves si el bloque de codigo IF contiene una sola linea de codigo.

Ahora tomemos un ejemplo muy similar, pero eliminemos la segunda variable para simplificar la demostracion:

    int x = 100;
    if (x > 200)
        Console.WriteLine("x is greater than 200"); 
    else
        Console.WriteLine("x is lesser than 200"); 

Tenemos una sola variable entera cuyo valor es 100 tal cual haciamos antes, agregaremos una sentencia IF, aunque esta vez la condicion sera levemente diferente. Esta vez la evaluacion es, si x es mayor a 200 o no, si no es mayor a 200 entonces el bloque de codigo que le sigue no se ejecutara. Como bien sabemos cuando esta condicion se evalue en tiempo de ejecucion, el resultado efectivamente sera falso, por lo cual puedo aprevechar esta oportunidad para agregar justo debajo del bloque de codigo, una condicion ELSE.

Basicamente esto se lee asi. Si x es mayor a 200, entonces imprime este mensaje de consola "x is lesser than y", y sino imprime este otro "x is lesser than 200". EL bloque de codigo que esta en el else sera ejecutado solo si el primer if es falso y en este caso en particular, ademas, podemos estar seguros de que el valor de x no es mayor a 200 cuando llegue a esta porcion de codigo. Este ultimo ejemplo, es el ejemplo clasico de un condicional IF ELSE.

Lo ultimo que tenemos que saber del condicional IF es que soporta multiples sentencias ELSE en esta forma:

    if (condicion) 
    {
        // Code to run when condition == true
    }
    else if (condition2)
    {
        // Code to run when condition2 == true
    }
    else
    {
        // Code to run when all above are false
    }
    
Cuando la primera condicion es falsa, entonces la secuencia pasara a evaluar la condicion del segundo IF, si es falsa entonces sale por el ELSE. Esto nos permite crear una cadena de condiciones para cuando los resultados de las evaluaciones son sucesivamente falsos.

No hay un limite en cuanto a la cantidad de else if podemos tener dentro de un condicional IF, aunque si es importante decir que si tenemos muchos, es probable que exista otra estructura de control que se ajuste mejor a lo que necesitamos.
