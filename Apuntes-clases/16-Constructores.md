16 - CONSTRUCTORES

Los constructores son metodos especiales que se usan cuando la clase se instancia, algo de esto ya hemos visto.
Un constructor nunca puede devolver nada y es por eso que no tiene un tipo de datos de retorno como lo tienen los metodos regulares.

Mientras que un metodo normal se define asi:

public string MethidName()
{
    // Code block
}

Un constructor se define asi:

public Person()
{
    // Code block
}

En el ejemplo que vimos antes en este modulo, teniamos el constructor de la clase Person, que tomaba un parametro string name, pero es importante decir que pueden convivir en una misma clase mas de un constructor como por ejemplo en el siguiente caso:

public Person() {}
public Person(string name)
{
    this.name = name;
}

En este ejemplo tendriamos dos constructores, uno con parametros y el otro sin parametros ya que los dos constructores hacen referencia a distintas maneras de instancias la misma clase. 

Siguiendo con el ejemplo la clase Person se podria instanciar de estas formas:

Person john = new Person();
Person john = new Person("John");

En resumen, los constructores definen la forma en la cual la clase sera inicializada, podemos optar por agregar parametros o dejarlos vacios.

Si no se especifica ningun constructor, por defecto la clase tendra siempre un constructor sin parametros.
