37 - SWITCH

Cuando necesitemos evaluar una variable con mas de dos o tres condiciones, en lugar de usar una gran IF con muchos ELSE, podemos utilizar la sentencia switch.

La sentencia switch comienza con la palabra clave switch que puede contener una variable como en este caso o tambien una expresion, siempre que el tipo de datos resultado de la expresion sea char, string, bool, int ó enum.

    int x = 10;
    switch (x)
    {
        case 0:
            Console.WriteLine("x is 0");
        break;
        case 10:
            Console.WriteLine("x is 10");
        break;
        default:
            Console.WriteLine("x is not 0 or 10");
        break;
    }

El resultado de esta expresion o el valor de la variable dentro del switch sera comparado con cada uno de los valores especificados en los cases, algo importante a tener en cuenta es que un case debe ser definido con un valor constante, es decir, que no puede tener valores variables. Ademas casa instruccion case debe terminar con dos puntos y a continuacion puede contener uno o mas a ser ejecutadas cuando esa condicion sea verdadera. Estas lineas entonces seran ejecutadas solo si el valor constante del case y el valor variable del switch coinciden.

En el anterior ejemplo, tenemos una variable x que es igual a 10, dentro del switch se evalua esa variable y como conocemos el valor de x sabemos que la unica linea que se ejecutará es la que esta dentro del case 10, ademas, toda clausula switch tiene una instruccion default, que es la que ven al final de este switch de ejemplo y que es opcional, es decir, que puede o no formar parte de la clausula, no es obligatorio. 

Default se utiliza para especificar una salida para cuando la evaluacion del switch no coincide con ninguno de los cases. 

Si por ejemplo x no fuera ni 10 ni 0, no coincidiria con ninguna de las constantes de los cases, por lo que el codigo del default seria ejecutado.

Noten tambien que cada uno de los casos tiene una instruccion break, esta palabra clave es obligatoria para delimitar una salida a la instruccion switch. Tengan en cuenta que en cuanto la ejecucion de la aplicacion entra a uno de los cases, obviamente ninguno de los otros casos sera ejecutado y sera necesario salir de la clausula switch para seguir la aplicacion.

Alternativamente a la palabra clave break, se puede usar la palabra clave return para retomar la ejecucion.

La clausula switch tambien permite combinar cases para ejecutar las mismas sentencias. De la siguiente forma:

    int x = 10;
    switch (x)
    {
        case 0:
        case 1:
            Console.WriteLine("x is 0 or 1");
        break;
        case 10:
        case 11:
            Console.WriteLine("x is 10 or 11");
        break;
        default:
            Console.WriteLine("x is not in 0, 1, 10, 11");
        break;
    }

En este ejemplo, cuando x sea cero o sea 1, el primer case sera ejecutado y cuando x sea 10 u 11 entonces el segundo case sera ejecutado. Si ninguno de los cases coincide con el valor de x, el codigo del default sera ejecutado. Es decir, que lo que hacemos aqui no es mas que agrupar las opciones y definir una porcion de codigo o un bloque de codigo que sea ejecutado cuando alguno de esos valores coincida.
