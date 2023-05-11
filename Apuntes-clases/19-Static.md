19 - STATIC

Como ya estudiamos, la manera habitual de utilizar una clase es creando una instancia nueva de la clase y trabajando con el objeto para acceder a sus metodos y propiedades.

En la gran mayoria de los casos es asi como se usara siempre, creando multiples instancias de la misma clase segun que cosas se necesiten. Sin embargo en algunos casos muy particulares, es util tener una clase cuyos elementos puedan ser utilizados sin la necesidad de que la clase sea instanciada, es decir sin que haga falta crear un objeto para acceder a sus metodos y propiedades.

Por ejemplo, podria ser que tengamos una clase con una variable cuyo valor nunca cambia sin importar como y donde se usa, esto es lo que se conoce como miembro estatico.

Una clase puede ser estatica y puede tener miembros estaticos, es decir metodos y campos. una clase estatica no puede ser instanciada, por lo que si lo pensamos friamente en el fondo, una clase estatica es un grupo de miembros que se relacionan entre si que una clase propiamente dicha.

Este es un ejemplo de una clase estatica con un miembro estatico:

public static class Calculations
{
    public static int GetSum(int n1, int n2)
    {
        return n1 + n2;
    }
}

En la definicion de la clase, despues del modificador de acceso public que decide la visibilidad de la clase, se encuentra la palabra clave static y la misma palabra aparece de nuevo en el metodo GetSum() antes del tipo de retorno del metodo, es decir que tanto clase como metodo son estaticos.

Un ejemplo de como usariamos este metodo, es el siguiente:

public static class Calculations
{
    public static int GetSum(int n1, int n2)
    {
        return n1 + n2;
    }
}

Console.WriteLine(Calculations.GetSum(2, 5));

Esta es la ventaja de los metodos estaticos y de las clases estaticas, que no hace falta crear un objeto para poder acceder a sus metodos y propiedades.

Repasemos algunas reglas generales a la hora de usar la palabra static:

    * Una clase estatica solo puede contener metodos estaticos.
    * Una clase no estatica puede contener metodos y propiedades estaticas, aunque no pueden ser accedidos desde los objetos
    * Una clase no estatica que contiene metodos y propiedades estaticos, puede ser instanciada como cualquier otra clase solo que sus miembros estaticos no estaran disponibles desde las instancias.