15 - METODOS

Un metodo realiza una o varias acciones y puede o no entregar un resultado. En otros lenguajes de programacion se conocen como funciones, pero en c# cuando pertenecen a una clase son llamados simplemente metodos.

Los metodos son utiles porque nos permiten encapsular porciones de funcionalidad para luego poder ejecutrla una y otra vez desde diferentes lugares.

Un metodo se define de la siguiente manera: 

<visivility> <return type> <name> (<parameters>) 
{
    <code>
}

Como se puede observar, en la firma del metodo que es la primera linea del metodo, tenemos que definir una visibilidad  tambien un tipo de datos de retorno, es decir, ue va a devolver ese metodo (si es que devuelve algo) acontinuacion el nombre del metodo y opcional entre parentesis una lista de parametros qunte puede tambien no necesitar ningun parametro y luego entre llaves, va a estar el codigo del metodo en si.

Veamos un ejemplo concreto para que sea mas grafico:

public int Multiplicar (int number1, int number2)
{
    return number1 * number2;
}

En el ejemplo anterior, tenemos un metodo muy sencillo que recibe dos numeros enteros por parametros los multiplica y devuelve el resultado. Si lo analizamos palabra por palabra, vamos a encontrar que el metodo tiene primero una visibilidad publica, tambien tiene un tipo de retorno int es decir que el metodo retornara un valor entero y que tambien tiene un nombre que es Multiplicar, acontinuacion y entre parentesis aparecen dos parametros que son los valores que el metodo recibira ambos de tipo int y separados por coma (,). Por ultimo y entre llaves esta el codigo del metodo propiamente dicho, que en este caso no es mas que la multiplicacion de los valores recibidos por parametro. La palabra clave return, indica que esa es la ultima linea del metodo y que justamente esa multiplicacion sera lo que el metodo devuelva.

Para llamar este metodo simplemente usaremos su nombre seguido de los parentesis y pasaremos por parametros los dos numeros de tipo entero que queremos multiplicar. Si el metodo no recibiera ningun parametro, entonces los parentesis quedarian vacios, pero deberian escribirse de cualquier manera.

Ahora como el metodo multipllicar a definido que recibe dos parametros, estos parametros son obligatorios. No se puede utilizar el metodo sin pasar esos dos argumentos.

Respecto al tipo de datos de retorno, necesitamos aprender dos cosas importantes: 

1. En muchos casos no necesitamos que el metodo retorne algun tipo de resultado, aveces solo queremos que se ejecute cierta logica sin devolver ningun valor. Para lograr esto tenemos que escribir la palabra clave "void" en el lugar en el que iria el tipo de retorno del metodo, esto le dira al compilador que la palabra clave return no aparecera en ningun lugar de nuestro metodo por que no habra ningun valor para devolver.

Veamos un ejemplom de una funcion void:

public void HacerAlgo(int number1, int number2) 
{
    int number3 = number1 * number2;
    Console.WriteLine(number3);
}

El anterior ejemplo es un caso en particular de la implementacion de un metodo de tipo void. Este metodo no necesita retornar nada porque simplemente queremos imprimir en consola, la multiplicacion de los dos numeros recibidos por parametros.

Lo ultimo que vamos a estudiar de los metodos, son los parametros opcionales, veamos una vez mas el ejemplo de metodo Multiplicar.

public int Multiplicar (int number1, int number2)
{
    return number1 * number2;
}

Como ya habiamos dicho este metodos recibe dos paramtros de tipo int number1 y number2. En tes caso al tener el metodos dos parametros definidos, es obligatorio que cuando se llame al metodo, se pasen estos dos paremtros. Si a la hora de invocar el metodo, no se especifican los parametros que ademas deben se de tipo int, entonces el compilador devolvera un error  y la aplicacion no compilará.

En conclusion, los parametros que definimos en la firma del metodo, luego seran obligatorios cuando necesitemos usar el metodo. Sin embargo existe la posibilidad de agregar parametros opcionales, es decir parametros que definamos en la firma del metodo pero que despues podemos o no enviar cuando lo invoquemos.

En c# un parametro es opcional cuando se le define un valor por defecto en su declaracion.

public int Multiplicar (int number1, int number2, int number3 = 0)
{
    return number1 * number2;
}

En el anterior ejemplo, vemos que el parametro number3 tiene un valor por defecto de cero (0) por lo cual si no es suministrado a la hora de invocar el metodo entonces tendra un valor de cero (0) a la hora de ser utilizado como por ejemplo: 

Multiplicar(2, 5); // No pasamos el numero valor para el tercer parametro a lo cual en la funcion valdra cero
Multiplicar(2, 5, 6); // En esta invocacion si pasamos el tercer numero y tomara el valor de 6 en la funcion

Esta es la ventaja de los parametros opionales, que podemos sumininistrar un valor por defecto dado el caso que el usuario decida no pasarlo. Tampoco existe restriccion en cuanto a la cantidad de paramtros opcionales, si quisieramos todos los paramtros del metodo podrian ser opcionales.

public int Multiplicar (int number1 = 0, int number2 = 0, int number3 = 0)
{
    return number1 * number2 * number3;
}