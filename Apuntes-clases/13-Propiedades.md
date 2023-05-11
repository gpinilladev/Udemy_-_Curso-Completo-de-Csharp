13 - PROPIEDADES

Antes habiamos aprendido que un field es una variable global en una clase que nos permite accederla desde cualquier metodo, tambien dijimos que habian algunas formas de acceder a ese field o ese campo desde afuera de la clase, como por ejemplo cambiando su acceso de privado a publico (lo cual tambien dijimos que no era recomedable) o utilizando algun constructor que tiene algunas limitaciones que tambien ya veremos. Es realmente a traves de las propiedades que podemos acceder a los fields de nuestra clase desed afuera de la clase. 

* Esta es la manera en la que se debe hacer:

Class Person {

    private string name;
    public string Name {
        get { return name; }
        set { name = value; }
    }

}

Una propiedad es en cierta forma un punto intermedio entre un campo y un metodo porque se declara igual que un campo con un modificador de acceso generalmente public o protected, un tipo de datos y un nombre, pero a diferencia de un field, la propiedad tiene un cuerpo para controlar el comportamiento. Como se puede observar en el ejemplo anterior, adentro de la propiedad tenemos dos palabras claves, get y set, estas dos palabras claves, se usan exclusivamente en las propiedades para controlar cuando queremos leer el valor de un field con el get y para cuando queremos asignar el valor al field con el set. A su vez se pueden cear propieddades con tan solo el metodo get o con tan solo el metodo set para conseguir propiedades de solo lectura o de solo escritura, pero este ejemplo conforma el caso mas clasico de como propiedad y field funcionan juntos, el metodo get devuelv el valor del field name y el metodo set asigna el valor al field name, en el set se utiliza una palabra clave que es "value", que hace referencia al valor pasado a la propiedad para actualizar el field.

La ventaja de las propiedades es que el field permanece privado y solo puede ser actualizado y retornado atraves de su propiedad, con lo cual el control sobre el valor del field es total, ya que el unico lugar en donde se actualiza esta centralizado en la propiedad.

Para ampliar aun mas en propiedades tengamos en cuenta que los metodos de ls propiedad pueden ser tan complejos como se nos ocurra.

Consideremos un caso en el que el valor del field no sea asignado y devuelto tradcionalmente, sino que por el contrario sea modificado justo antes de ser devuelto y justo antes de ser asigndo.

Class Person {

    private string name;
    public string Name {
        get { return "The name is " + name; }
        set { 
            if(value.Contains(","));
                throw new Exception("Error");
            name = value;
        }
    }

}

Ahora la propiedad se ve completamente diferente, primero que mas alla de lo que tenga el valor del campo, el metodo get siempre entregara una cadena de texto de la forma "The name is " mas el valor del campo, es decir que hay una modificacion en la forma en la que se devulve el valor, y cuando la propiedad se accedida por fuera de la clase esa sera la forma que tomara. Lo mismo sucede con el set, que en esta implementacion el valor de value sera asignado al campo name solo si cumple con que el valor o value no contenga ninguna coma (,), de no ser asi ocurrira un error. Esto demuestra que podemos escribir dentro de nuestras propiedades tanta logica como haga falta.

En la gran mayoria de los casos las propiedades no necesitaran de un tratamiento especial ni necesitaran logica extra mas que la de servir como un acceso publico los campos, por lo que en el 95% de los casos tan solo se necesitaran las propiedades que vimos en el primer ejemplo, las clasicas.

Class Person {

    private string name;
    public string Name {
        get { return name; }
        set { name = value; }
    }

}


Para ahorrar codigo y ahorrar el fastidio de escribirlo varias veces, es que .ney nos ofrece las propiedades autoimplementadas en donde esto: 

Class Person {

    private string name;
    public string Name {
        get { return name; }
        set { name = value; }
    }

}

Lo podemos replazar con lo siguiente y tendra el mismo uso:

Class Person {

    public string Name { get; set; }

}

Como ven, ni siquiera tenemos que agregar el campo explicitamente. Internamente el comportamiento sera el mismo que ya hemos visto. Existira una variable privada que solo sera accesible a traves de la propiedad pero en tiempo de desarrollo con tan solo escribir esa linea de codigo lograremos exactamente lo mismo y asi es como se veran definidas en la gran mayoria de los casos.

Tambien existe la posibilidad de inicializar una propiedad autoimplementada con un valor por defecto:

Class Person {

    public string Name { get; set; } = "John Wick";

}
