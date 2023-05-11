08 - OPERADORES

Los operadores son simbolos especiales que ejecutan ciertas acciones sobre los operandos, por ejemplo en matematicas el simbolo + realiza la suma entre el numero que esta a la izquierda y el que esta a la derecha. De la misma manera c# ofrece varios operadores para distintos tipos de operaciones. Algunos operadores funcionan de manera diferente segun el tipo de dato de los operandos.

Operando 1 + Operando 2

int a = 10 + 10;
int b = a + 5;

string c = "Hola" + "mundo";

Por ejemplo en este caso el simbolo + que primero sumara dos valores de tipo entero y en cambio concatenara despues dos cadenas de texto. Vemos que con el mimso simbolo obtenemos resultados distintos segun el tipo de datos de las variables o los operandos.

Los operadores aritmeticos realizan operaciones aritmeticas en todos los operandos numericos como byte, short, int, long, float, double y decimal, entre otros. 

Veamos los operadores 

* Operadores aitmeticos

 Operador         Name                 Example
    +           Addition            int x = 5 + 5;
    -           Substraction        int x = 5 - 4;
    *           Multiplication      int x = 5 * 2;
    /           Division            int x = 100 / 5;
    %           Reminder            int x = 5 % 2;
    ++          Unary increment     int x = x++;
    --          Unary decrement     int x = x--;

* Operadores de comparacion
Tambien tenemos los operadores de comparacion que basicamente comparan dos operandos numericos y devuelven un valor booleano (verdadero o falso). 

Operados    Example
    <       x < y       
    >       x > y
    <=      x <= y
    >=      x >= y

* Operadores de igualdad
Tambien tenemos los operadores de igualdad que asicamente se encargan de determianr si dos operandos son iguales o no. 

Operados    Example
    ==       x == y       
    !=       x != y

* Operadores logicos booleanos 
Tambien tenemos como parte del lenguaje los operadores logicos booleanos, que en realidad lo tiene casi todos los lenguajes de programacion.

 Operador   Logical operator    Example
    !           NOT             !false
    &&          AND             x && y
    ||          OR              x || y
    