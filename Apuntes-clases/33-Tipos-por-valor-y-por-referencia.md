33 - TIPOS POR VALOR Y POR REFERENCIA

- TIPOS DE DATOS POR VALOR

Se dice que un tipo de datos es un tipo por valor o value type si almacena el valor en su propio espacio de memoria, por ejemplo, si tenemos una variable i de tipo int cuyo valor es 100:

    int i = 100;

Entonces el sistema almacenara 100 en el espacio  de memoria designado para i que hipoteticamente diremos que esta en la direccion 0x228110 asi es basicamente como se asignan espacios de memoria a variables de tipo por valor.

Los mas comunes de tipo de datos por valor, son: 

    * bool
    * byte
    * chart
    * decimal
    * double 
    * int 
    * float 
    * long

Pero te estaras preguntando ¿Para que sirve esto en la practica?, y en un ejemplo veremos la importancia que tiene este concepto de tipo de datos por valor y tipo de datos por referencia y porque es importante conocerlo.

A la hora de pasar valores por parametros es donde aparece la diferencia prinicipal entre tipos de datos por valor y tipos de datos por referencia. Cuando pasamos una variable de tipo de datos por valor de un metodo al otro, el sistema crea una copia de la variable en el otro metodo, esto significa que si el valor de la variable cambia adentro de uno de los metodos, esto no afectaria el valor de la variable en el otro metodo.

Imaginemos entonces un metodo como este incrementValue() que recibe por parametros un tipo int que dijimos es un tipo por valor y adentro del metodo se actuliza el valor de ese parametro, sin importar el valor que la variable ya tenga: 

    static void incrementValue(int n)
    {
        n = 20;
        Console.WriteLine(n);
    }

Y ahora pensemos en otro metodo, un metodo setValue() que se ejecuta probablemente antes que el metodo incrementValue() y que en medio del proceso invoca le pasa el valor de n por parametro:

    static void setValue()
    {
        int n = 10;
        Console.WriteLine(n);
        incrementValue(n);
        Console.WriteLine(n);
    }

Este sera el resultado:

    10
    20
    10

Noten el orden de la secuencia, primero se declara la variable n y se inicializa con un valor de 10, ese es el primer valor que imprimimos en consola, luego se llama el metodo incrementValue() y se le pasa por parametros n que sabemos que vale 10, pero como dijimos que los tipos de datos por valor crean una nueva copia del valor de la variable cuando a n se le asigna un valor de 20 dentro del metodo incrementValue(), este nuevo n es un espacio de memoria diferente al primero que esta en el metodo setValue() por eso cuando imprimamos este segundo valor en la consola el valor sera de 20 y despues de eso cuando la secuancia vuelva al metodo setValue(), el valor de n se imprima por ultima vez, el valor sera de 10 porque en este caso se estara imprimiendo la variable n local al metodo setValue() que nunca ha cambiado y que nada tiene que ver con la variable n local al metodo incrementValue(), que esta en un espacio de memoria completamente diferente.

- TIPOS DE DATOS POR REFERENCIA

A diferencia de los tipos de datos por valor, un tipo de datos por referencia no almacena el valor directamente, sino que almacena la direccion de memoria en donde el valor es almacenado, en otras palabras, un tipo de datos por referencia contiene un puntero a otro espacio de memoria que es el que tiene realmente el valor.

    string s = "Hi";

En este caso, pensemos una variable de tipo string, que es un ejemplo de tipo de datos por referencia. Repasemos como funciona la asignacion de memoria aqui. Cuando la vairable s es inicializada, el sistema selecciona aleatoriamente una direccion de memoria, en este caso vamos a suponer que esta en la direccion 0x228110, ese es el lugar en donde estara la variable s, el valor de la variable s es 0x230000 que es la direccion de memoria en donde efectivamente esta el valor. Cuando la variable s es inicializada el sistema selecciona aleatoriamente una direccion de memoria en este caso 0x228110 para la variable s, el valor de la variable s es 0x230000 que es la direccion de memoria en donde efectivamente esta el valor almacenado, entonces el tipo por referencia, como deciamos, almacena la direccion de memoria en donde el valor se almacena, pero no el valor en si mismo.

Los tipos de datos por referencia mas comunes son:

    * string
    * array
    * class
    * delegate

Para compararlo con tipo de datos por valor veamos como se comporta una variable de tipo de datos por referencia cuando es pasada como argumento de otro metodo.

Igual que antes imaginemos un metodo updateValue() que recibe por parametros una variable de tipo Contact que es una clase de nuestro sistema:

    static void updateValue(Contact con)
    {
        con.Name = "Alan";
    }

Este metodo lo unico que hace es cambiar el nombre de ese contacto por Alan. Ahora supongamos que tenemos un metodo setValue() que se ejecuta antes que updateValue() y que declara e inicializa la variable c de tipo Contact y le asigna Mark como su nombre:

    static void setValue()
    {
        Contact c = new Contact();
        c.Name = "Mak";
        updateValue(c);
        Console.WriteLine(c.Name);
    }

luego de eso llama al metodo updateValue() en donde la actualizacion del nombre sucede y por ultimo imprime el nombre del contacto por consola.

El resultado sera:

    Alan

A diferencia de lo que sucedia antes, ahora la variable que se ha modificado en el segundo metodo si que ha cambiado cuando consultamos su valor desde el primero, esto se debe a que cuando la variable es enviada por parametros no se crea una copia del espacio de memoria, sino que lo que pasa por parametros es la direccion de memoria en donde esta el valor por lo cual ambas variables, tanto la local al metodo updateValue() como la local al metodo setValue() estan apuntando al mismo espacio de memoria y por ende modificando el veradadero y unico valor de la variable.

