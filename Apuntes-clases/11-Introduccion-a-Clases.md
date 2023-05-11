11 - INTRODUCCION A CLASES

C# es un lenguaje completamente orientado a objetos, tanto asi que en c# todo es un objeto y por eso tiene sentido que aprendamos que es una clase y que es un objeto como parte de los conocimientos fundamentales de c#.

Cuando hablamos de clases y objetos podemos pensar por ejemplo en una clase "Verdura" y en cada una de las verduras como objetos de la clase "Verdura", lo mismo por ejemplo con la clase "Libro" y distintos libros como objetos o instancias de la clase "Libro".

Una clase describe todos los atributos de los objetos y tambien los metodos que definen el comportamiento de los objetos. Es decir que podriamos entender a las clases como plantillas o templates de objetos, y a los objetos como intancias de una clase, es decir como representaciones unicas e individuales de esa clase. 

Pensemos en un segundo ejemplo, cuando hablamos de una clase libro todos sabemos a que nos referimos, todos los libros tienen tapas, portadas, numero de paginas, capitulos, autores, etc. todo esta definido en la clase o template, pero lo particular de cada libro estara definido en cada objeto. Harry Potter no tendra la misma cantidad de paginas que Mobby Dick, ni tampoco tendra la misma imagen de portada. El valor concreto de la variable numero de paginas definida en la clase, estara en cada uno de los objetos, es decir que la variable numero de paginas o el espacio de memoria asignado para numero de paginas estara en la clase, pero el valor particular del numero de paginas estara en el objeto. Entonces podriamos decir que una clase es un grupo de metodos y variables relacionados entre si.

Una clase describe algo determinado y en la mayoria de los casos podemos crear instancias de una clase, y cada un de esas instancias es lo que conocemos como objetos y dentro de estos objetos se pueden utilizar las variables y los metodos antes definidos en la clase, apartir de una clase se pueden crear tantas instancias como sean necesarias y no hay ningun tipo de restriccion para eso.

Vamos a entender con un ejemplo, la clase Person.

Class Person {

    private string name;

    public Person(string name) {
        this.name = name;
    }

    public string Name {
        get { return name; }
        set { name = value; }
    }

    public string toString() {
        return "This person called" + Name;
    }

}

Esta clase Person tiene una sola variable de tipo string llamada name, que ha sido declarada como privada gracias a esa palabra clave private que esta justo antes de string osea el tipo de datos. Esto basicamente significa que esa variable name no puede ser accedida por fuera de la clase, esto es lo que se denomina como el scope de una variable, pero si miramos mas abajo aparece la propiedad Name que esta declarada de acceso publico gracias a la palabra clave public que esta justo antes del string, esta propiedad permitira que la variable name sea accedida desde afuera de la clase pero no atraves de la variable directamente sino atraves de la propiedad. Ademas, esta clase person tiene un constructor que es un metodo con el mismo nombre de la clase y que toma un valor como argumento, en este caso tambien un string para la variable name y como hay un solo en esta clase, objetos Person, solo pueden instanciarse si se les especifica un nombre. El ultimo metodo llamado toString(), simplemente devolvera una cadena de texto con la informacion que hay en la clase sobre esta persona, que como sabemos es solo name, pero devolvera este valor como parte de una cadena de texto mas larga y con un mensaje un poco mas amigable.

Ejemplo del metodo Main() en donde hay dos instancias de la clase Person. La primera es una instancia de Person llamada "John", el valor de name se agrega atraves del constructor, y atraves del metodo toString() el valor de la propiedad se imprimira por consola y asi mismo para la segunda instancia pero ahora con el nombre "Mark". Estas dos instancias son dos objetos de tipo Person completamente independientes uno del otro.

static void Main(string args[]) {
    
    Person person;
    
    person1 = new Person("John");
    Console.writeLine(person1.toString());

    person2 = new Person("John");
    Console.writeLine(person2.toString());

}

