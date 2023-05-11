26 - STRINGS

Aun sin definirlo formalmente, ya hemos estado utilizando este tipo de datos, asi que ya se daran a una idea de que hablamos cuando nos referimos a strings.

Tecnicamente un string es una serie de caracteres que representa un texto, puede ser un solo caracter, puede ser una palabra o puede ser una frase larga delimetada por comillas:

    "C"
    "Word"
    "This is a phrase"

C# contiene un tipo de datos especificamente destinado a almacenar estas cadenas de texto cuyo alias es string:

    "C"                     -> string c = "C";
    "Word"                  -> string word = "Word";
    "This is a phrase"      -> string phrase = "This is a phrase";

El tamaño maximo que puede ocupar un string en memoria son dos gigas, que seria el equivalente a algo asi como dos billones de caracteres, aunque en la practica dependera de la capacidad tecnica de la computadora que contiene el proceso.

En lecciones posteriores veremos cual es la manera mas eficiente de trabajar con cadenas de texto tan grandes.

Algo imporante para aclarar desde el principio y evitar confusiones, es que en c# hay dos manera de declarar una variable de tipo string, puede ser utilizando la clase System.string o puede ser utilizando el alias string:

    string txt1 = "Hi, there!";
    System.String = txt2 = "Hi, there!";

Tal cual aprendimos cuando vimos los tipos de datos primitivos, no hay ninguna diferencia entre usar el nombre de la libreria o su alias.

* CARACTERES ESPECIALES

Hasta ahora hemos aprendido que un string esta delimitado por comillas dobles, pero que pasa si necesitamos que el valor de la cadena de texto tambien incluya comillas dobles?.

Si intentamos escribir esto:

    string text = "Can I use this "string" within the string?"; // Error del compilador

Entonces el compilador entregara un error y es logico porque no puede identificar en donde comienza el string y en donde termina.

Para resolver este tipo de problemas C# incluye lo que se llama un caracter de escape, lo que significa que cualquier que siga al caracter de escape sera tomado como un texto literal por C# y el compilador no intentara interpretarlo, sino que lo imprimira directamente como texto.

En este caso el caracter de escape es la barra invertida "\".

    Escaping character: \

entonces para que el string de arriba compile habria que reescribirlo asi:

    string text = "Can I use this \"string\" within the string?"; // Error del compilador

De la misma forma, si quisieramos que nuestro string contenga una barra invertida, entonces deberiamos escapara la barra invertida con otra barra poniedo dos barras. asi:

    string path = "\\shared\\temp\\user";

Pero vean como en un caso como este se vuelvo un poco inconveniente agregar tantos caracteres de escape. Imaginemos que tuvieramos una ruta mucho mas larga, con muchas mas barras invertidas, para resolver este segundo problema y de pasp para que el codigo no se ensucie con tantos caracteres especiales, C# nos ofrece la posibilidad de utilizar otro caracter especial para indicarle al compilador que no intente nada de lo que sigue y que tome literal toda la cadena de texto.

Este caracter especial es el arroba "@" y debe ser utilizado antes de la primera comilla doble, asi: 

    string path = @"\shred\temp\user";

Y es asi entonces como podriamos escribir la anterios definicion anterior utilizando el nuevo caracter de escape. Mucho mas simple.

Ademas, como ya hemos visto varias veces, los strings pueden ser concatenados utilizando el simbolo "+", eston son algunos ejemplos similares a los que ya estudiamos:

    string name = "John" + "Wick";
    string firstName = "John";
    string lastName = "Wick";
    string client = "Mr. " + firstName + " " + lastName;

Un string es inmutable en C#, esto significa que es de solo lectura y no puede cambiar, una vez que ha sido creado en memoria, cada vez que se concatena un string, el motor del .NET creara un nuevo espacio en memoria para el string concatenado. Es por esto que en casos como este, se recomienda usar un tipo de datos que provee el framework de .NET que se llama String Builder en lugar de strings.

Estudiaremos esta clase en detalle mas adelante. 

* String Interpolation

String interpolation es un operador especial para trabajar con strings que permite hacer determinadas cosas que de otra manera no seria posible o seria muy complicadonde hacer, en realidad todo lo que String Interpolation permite es agregar en la cadena de texto determinados marcadores especiales que luego el compilador reemplazara con los valores correspondientes.

Pero como siempre, veamos un ejemplo ya que en la practica se aclaran los conceptos:

Supongamos que tenemos una variable cliente (client) y ademas una variable edad (age) y ahora supongamos que queremos usar el valor de estas dos variables en una nueva cadena de texto:

    string client = "Walter White";
    string age = "40";
    Console.WriteLine(client + " is " + age + " years old");

Asi, concatenando los valores, como ya hemos visto antes, conseguiriamos lo que necesitamos, pero veamos la diferencia de hacer lo mismo utilizando String Interpolation:

    Console.WriteLine($"{ client } is  { age } years old");

Como ven, la segunda opcion es mas limpia y mucho mas facil de leer.

Lo primero a anotar, es que justo delante de la cadena de texto hay un caracter especial que es el signo "$" pesos, ese es el simbolo necesario para poder utlizar interpolation, y luego esta la cadena de texto completa, es decir, hay una comilla doble al principio y otra al final, no hay pqeueñas cadenas de texto concatenadas y ademas las variables client y age esta inyectadas dentro de la cadena de texto cada una de ella enceraada entre llaves, estas llaves con las que le dicen al compilador que lo de adentro es una variable y que todo lo que esta entre llaves sera reemplazado por el valor de la variable, pero el uso de estas llaves no se reduce al valor de una variable asi sin mas, a decir verdad, las llaves pueden contener expresiones C# mas complejas, por ejemplo:

    Console.WriteLine($" 10 + 5 * 2 = { (5 + 5) * 2 } ");

En este ejemplo, el resultado de esta expresion sera reemplazado por todo lo que esta entre llaves gracias a String Interpolation.