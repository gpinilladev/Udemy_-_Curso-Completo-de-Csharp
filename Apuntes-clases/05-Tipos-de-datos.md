05 Tipos de datos

El tipo de datos es el que le dice al compilador de c# que tipo de valor puede almacenar una variable. Ademas como dijimos en la clase anterior, c# es un lenguaje fuertemente tipado lo que significa que el valor de una variable de un tipo concreto, no se puede usar como si fuera de otra tipo. Este concepto quedara claro conforme el curso avance.

Tipos de datos primitivos

    C#	    Tipo en System	Características	                           Símbolo

    sbyte	  System.Sbyte	  entero, 1 byte con signo
    byte	  System.Byte	    entero, 1 byte sin signo
    short	  System.Short	  entero, 2 bytes con signo
    ushort	System.UShort	  entero, 2 bytes sin signo
    int	    System.Int32	  entero, 4 bytes con signo
    uint	  System.UInt32	  entero, 4 bytes sin signo	                U
    long	  System.Int64	  entero, 8 bytes con signo	                L
    ulong	  System.ULong64	entero, 8 bytes sin signo	                UL
    float	  System.Single	  real, IEEE 754, 32 bits	F
    double	System.Double	  real, IEEE 754, 64 bits	D
    decimal	System.Decimal	real, 128 bits (28 dígitos significativos)	M
    bool	  System.Boolean	(Verdad/Falso) 1 byte
    char	  System.Char	    Carácter Unicode, 2 bytes	                ´ ´
    string	System.String	  Cadenas de caracteres Unicode	            " "
    object	System.Object	  Cualquier objeto (ningún tipo concreto)

* Tipos numericos integrados
Tambien conocidos como numeros enteros porque por que en si representan los numeros enteros. Todos ellos admiten operadores:
    * Aritmeticos
    * Logicos
    * Comparacion de igualdad

- El valor predeterminado de los tipos de datos numericos integrados es de cero (0).

Keyword     .Net Type          Range            Size
  byte     System.byte       0 to 255           8 bits
  short    System.Int16   -32.768 to 32.767     16 bits
  int      System.Int32      -2B to 2B          16 bits
  long     System.Int64                         64 bits

* Tipos numericos de punto flotante
Son tambien denominados numero reales
Todos ellos admiten operadores:
    * Aritmeticos
    * Logicos
    * Comparacion de igualdad

- El valor predeterminado de los tipos de datos numericos flotantes es de cero (0).

Keyword     .Net Type          Range            Size
  float     System.Single      6 to 9 digits    4 bytes
  double    System.Double      15 to 17 digits  8 bytes
  decimal   System.Decimal     28 to 29 digits  16 bytes

* Tipos boolean
Representa un valot booleano que puede ser true o false (verdadero o falso)

- El valor predeterminado de los tipos de datos boolean es false.

Keyword     .Net Type    
  bool     System.Boolean

* Tipos char
Representa un un caracter unico utf-16, como una letra.
Admite operaciones de:
    * Igualdad
    * Comparacion
    * Incremento
    * Decremento

Keyword     .Net Type    size
  char     System.Char   16 bits
