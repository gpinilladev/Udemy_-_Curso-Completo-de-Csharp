23 - ENUM

Un Enum o enumerador es un tipo especial de clase que representa un grupo de constantes, es decir, valores de solo lectura que no pueden modificarse.

Para crear un enum, utilizaremos la palabra clave "enum" y separaremos los valores del enumerador con comas.

enum Categories 
{
    Food, 
    Snacks, 
    Drinks 
};

La sintaxis es tan sencilla como agregar el nombre del enumerador seguido de punto y seguido del valor que queremos obtner. Por ejemplo:

Categories cat = Categories.Food;
Console.WriteLine(cat);

En el anterio ejemplo de la enumeracion catergorias, tenemos una variable que se llama cat que es de tipo enum y para obtener el valor de Food hacemos Categories.Food, de ese modo lo que veremos impreso en pantalla sea justamente Food la cadena de texto de la categoria.

Por defecto, todos los enumeradores tienen valores enteros aunque no se hagan explicitos.

enum Categories 
{
    Food,   // 0
    Snacks, // 1
    Drinks  // 2
};

En este caso, aun aunque no lo diga la categoria Food tambien tiene un valor que le corresponde entero que es cero (0), Snacks le corresponde un uno (1) y Drinks le corresponde un dos (2).

Para obtener este valor entero debemos castear el valor del enumerador a un entero, muy parecido al ejemplo anterior:

int catNumber = (int)Categories.Food;
Console.WriteLine(catNumber);

En este caso tenemos una variable de tipo entero que se llama catNumber, que es en donde vamos a almacenar el valor entero de esa categoria y lo siguiente es indicar el nombre del enum Categories.Food y eso lo casteamos a un entero y por lo tanto obtendremos en estes caso el valor cero (0).

Si necesitamos valores diferentes a los que .Net ofrece por defecto, tambien podemos agrefarllos explicitamente en el enumerador, la forma de obtener este nuevo valor no cambia en nada respecto al anterior ejemplo:

enum Categories 
{
    Food = 4,
    Snacks = 7,
    Drinks = 9
};

int catNumber = (int)Categories.Food;
Console.WriteLine(catNumber);

Fijense que ya no tenemos 0, 1, 2 sino que tenemos numero enteros que representan cosas que quizas a nosotros no interesan como 4, 7 y 9. Es decir que lo enumeradores, soportan un tipo de texto y tambien un tipo entero.
