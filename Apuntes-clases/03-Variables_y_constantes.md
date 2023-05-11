03 - VARIABLES Y CONSTANTES

Las variables son el elemento fundamental de todo lenguaje de programacion, a partir de las variables y de 
su combinacion con los operadores y las estructuras de control, se construye la logica de cualquier sistema.

Entonces una variable se puede entender escencialmente como un contenedor de informacion. Dentro de ese contenedor 
de informacion podemos almacenar informacion, obtener la informacion almacenada y tambien modificarla.

Pero una definicion mas tecnica seria que una variable es en realidad un espacio de memoria con un nombre especifico 
que alamacena el valor de un tipo de dato particular, luego ese espacio en memoria puede ser acceduido por el 
sistema atraves de su nombre.

En C# una variable se define de la siguienete manera y de forma basica:

[data type] [identifier];

Ejemplo:

string customer;

Existe la posibilidad de definir las variables con un valor inicial:
[data type] [identifier] = [value];
string customer = "John Wick";

Algunos tipos de variables son:
    C#	    Tipo en System	Características	                           Símbolo

    sbyte	System.Sbyte	entero, 1 byte con signo
    byte	System.Byte	    entero, 1 byte sin signo
    short	System.Short	entero, 2 bytes con signo
    ushort	System.UShort	entero, 2 bytes sin signo
    int	    System.Int32	entero, 4 bytes con signo
    uint	System.UInt32	entero, 4 bytes sin signo	                U
    long	System.Int64	entero, 8 bytes con signo	                L
    ulong	System.ULong64	entero, 8 bytes sin signo	                UL
    float	System.Single	real, IEEE 754, 32 bits	F
    double	System.Double	real, IEEE 754, 64 bits	D
    decimal	System.Decimal	real, 128 bits (28 dígitos significativos)	M
    bool	System.Boolean	(Verdad/Falso) 1 byte
    char	System.Char	    Carácter Unicode, 2 bytes	                ´ ´
    string	System.String	Cadenas de caracteres Unicode	            " "
    object	System.Object	Cualquier objeto (ningún tipo concreto)

Reglas para la definicion de variables:

* El nombre de cada varaible debe ser unico.
* Solo pueden contener letras, numeros y guines bajos.
* Deben comenzar con una letras
* Son case-sensitive, es decir que 2 variables name y Name son totalmente diferentes.
* No pueden contener palabras reservadas.
* Por convencion debe tener la notacion camelCase.

Si con las variables denominamos valores que se pueden cambiar, con las constantes es lo opuesto.
Cuando se declara una cosntante su valor debe ser definido inmediatamente y despues de eso no se puede 
realizar ningun cambio al valor de la variable.

En general, las constantes se utilizan cuando necesitamos tener un elemento cuyo valor no cambie nunca 
dentro del flujo del sistema, ni siquiera por accidente.