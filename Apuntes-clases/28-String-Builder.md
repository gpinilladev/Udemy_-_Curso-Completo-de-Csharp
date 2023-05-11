28 - String Builder

Como ya dijimos, el tipo de datos String es inmutable, lo que significa que no puede modificarse una vez ha sido creado, claro que en la practica podemos actualizar el valor de cualquier variable de tipo String, solo que lo que sucede detras de escena es que el compilador va a crear un nuevo espacio de memoria para almacenar el nuevo valor de la variable.

Supongamos que partimos de la variable que teniamos antes:

    string client = "John Wick"; // Espacio de memoria ejemplo => 0x82230

Esta variable ocupa un espacio en memoria, Cuando modificamos el valor de la variable ahora, un nuevo espacio de memoria le sera asignado.

    string client = "John Wick"; // Espacio de memoria ejemplo => 0x82230
    client = "Walter White is Heisenberg"; // Espacio de memoria ejemplo => 0x90220

Cuando modificamos el valor de la variable ahora, un nuevo espacio de memoria le sera asignado. Lo que sucede con esto es que si el string original es modificado demasiadas veces por la razon que sea, entonces la performance obviamente se vera comprometida.

Para solucionar este problema, C# agrega la clase String Builder, este no crea un nuevo objeto en memoria cada vez que el string se modifica, sino que en cambio expande la memoria dinamicamente para ir adaptandola al nuevo string, lo que permite a nuestra aplicacion aprovechar mucho mejor los recursos del sistema.

Un String Builder debe ser inicializado como cualquier otra clase usando la palabra clave new, y puede ser inicializado asi sin pasar ningun valor predeterminado:

    StringBuilder sb = new StringBuilder();

Tambien se puede usar uno de sus constructores predeterminador y enviar el texto inicial de nuestra cadena como String Builder, asi:

    StringBuilder sb = new StringBuilder("Hi there!");

Como String Builder no es un un string perce, para devolver el valor de un String Builder tendremos que usar el metodo ToString() del objeto. En este caso entonces la variable txt contendra el valor del String Builder, asi:

    StringBuilder sb = new StringBuilder("Hi there!");
    string txt = sb.ToString();

Tal cual lo estudiamos antes, el uso mas adoptado de la clase String Builder es el reemplazo directo de la concatenacion y para hacer esto la clase String Builder contiene el metodo append que como la palabra lo dice, consiste en anexar una nueva cadena de texto a la que ya existe en el objeto, y si no habia ninguna cadena de texto en el objeto, entonces lo inicializara.

Supongamos que tenemos el mismo String Builder de antes, y le agregamos dos cadenas de texto 

    StringBuilder sb = new StringBuilder();
    sb.Append("Hi there!");
    sb.AppendLine("How are you doing!");

Vean como en el segundo caso utilize el metodo AppendLine() que lo que hara sera agregar la nueva cadena a la cadena existente en una nueva linea, el resultado entonces sera este:

    Hi there!
    How are you doing!

String Builder nos permite realiazar otras operaciones con cadenas de texto. 

El metodo insert le permite agregar una cadena de texto en un indice especifico de la cadena, es decir, en una ubicacion particular y no al final de la cadena, la salida seria: 

    StringBuilder sb = new StringBuilder("Hi Wick");
    sb.Insert(2, " John");
    Console.WriteLine(sb.ToString());
    
    // Hi John Wich

Se ha insertado la palabra " John" entre las palabras "Hi" y la palabra "Wick", es decir, en un lugar muy puntual del string.

Tambien podemos remover cadenas de texto en cualquier lugar del string, con el metodo Remove(), indicando primero el indice a partir del cual comenzar a contar y luego la catidad de caracteres a remover, veamos un ejemplo:

    StringBuilder sb = new StringBuilder("Hi there!");
    sb.Remove(2, 6);
    Console.WriteLine(sb.ToString());
    // Hi

En este ejemplo se removeran los caranteres desde el indice 2, recuerden que C# los indices inician desde cero 0, seis lugares hacia adelante. La salida sera esta:

    // Hi

Se ha eliminado desde el espacia hasta la palabra "there" y el signo de exclamacion !. 

Otra de las operaciones mas poderosas del String Builder, es su metodo Replace(), lo bueno de este metodo es su simplicidad ya que simplemente tenemos que pasar como primer parametro la cadena que queremos reemplazar, y a continuacion, la cadena que la reemplazara. 

    StringBuilder sb = new StringBuilder("Hi there!");
    sb.Replace("there", "John");
    Console.WriteLine(sb.ToString());
    // Hi John

Para este ejemplo el compilador buscara todas las apariciones de la cadena "there" y reemplazara todas las que encuentre con la cadena "John". Es importante entender eso antes de usar el metodo Replace(), ya que si la cadena de texto es muy larga y hay varias apariciones de esta palabra, entonces todas seran reemplazadas por el valor "John". El resultado sera el siguiente:

    StringBuilder sb = new StringBuilder("Hi there!");
    sb.Replace("there", "John");
    Console.WriteLine(sb.ToString());
    // Hi John

En resumen estas son algunas cosas para repasar:

-> String Builder

    * Sting Builder es mutable, esto significa que el espacio de memoria se adapta dinamicamente, pero que puede cambiar a diferencia del String, que debe crear un nuevo espacio de memoria cada vez que la cadena de texto se actualiza

    * Mejor performance que String para unir multiples cadenas de texto, y podemos usar el metodo Append() para agregar cadenas de texto, el metodo Replace() para reemplazar porciones de la cadena y el metodo ToString() para devolver el valor del String Builder.

    * Podemos usar el metodo Append() para agregar cadenas de texto.
    
    * Podemos usar el metodo Replace() para reemplazar porciones de la cadena.

    * Podemos usar el metodo ToString() para devolver el valor del String Builder.

    * Podemos usar el metodo Remove() para eliminar porciones de la cadena.

