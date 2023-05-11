12 - CAMPOS / FIELDS

Uno de los ejemplos mas basicos de una clase es lo que se conoce como field o simplemente campo en español. Volvamos al ejemplo de la clase Person.

class Person {
    private string name;
}

Es esta clase teniamos una variable llamada name de tipo string, esto es justamente lo que se conoce como un field. Para definirlo tecnicamente diremos que en realidad un field es toda variable que este declarada dentro de una clase. Esta es la diferencia principal entre una simple varialble y un field, el lugar en donde esta declarada. Y aunque a simple vista parezca trivial, esta es una diferencia importante porque esta relacionada con lo que conocemos como el scope de una variable. 

El scope de una variable, es el que decide desde donde puede ser accedida esa variable, es decir que una variable local definida dentro de un metodo cualquiera solo podra ser accedida y utilizada adentro de ese metodo especifico, mientras que un field puede ser accedido por cualquiera de los metodos de la clase y hasta desde metodos de otras clases si la visibilidad lo permite, cosa que en el ejemplo anterior, no lo hace por que tiene un modificador de acceso que dice private. Es decir que la diferencia entre una variable regular y un field o campo, es el lugar en donde fue declarada.

Una variable declarada al nivel de una clase es un fied, y una variable declarada al nivel de cualquier metodo es simplemente una variable sin mas.

En el ejemplo anterior la variable name dentro de la clase Person, no tiene un valor inicial, es decir que habra que asignarle un valor antes de poder usarla.

Otra opcion es asignarle el valor de manera directa, cosa que tambien es perfectamente posible aunque lo veremos menos en general porque la idea es que se modifique atraves de las propiedades pero es igual valido de cualquier manera.

class Person {
    private string name = "John Wick";
}

La otra opcion es usar el constructor publico de la clase para asignarle el valor al field.

Class Person {

    private string name;

    public Person(string name) {
        this.name = name;
    }

}

Noten como se accede al field name de la clase, utilizando la palabra clave this, para acceder a variables de la clase dentro de la misma clase se utiliza la palabra clave this que basicamente indica que queremos el campo de esta misma clase y eso es lo que this representa.

El constructor se lee de la siguiente manera: 
"Dado un string name que llega por parametros, el valor de esta variable se le asigna al field name de la clase Person". 