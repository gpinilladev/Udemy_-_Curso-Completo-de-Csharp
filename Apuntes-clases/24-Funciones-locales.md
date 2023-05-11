24 - FUNCIONES LOCALES

Las funciones locales son menos frecuentes en c# por que aparecierob recien con c# 7.0, es decir que no estaban disponibles desde el principio, y por esto es posible que no te encuentres con tantas funciones locales cuando leas codigo c# que han escrito otros pero es importante conocer esta herramienta por el gran potencial que tiene.

Tal cual ya lo habiamos visto con variables aqui es importante entender el concepto de scope.

Cuanod declaramos una variable adentro de un metodo, es variable solo sera accesible dentro de ese metodo, no hay modificadores de acceso posibles cuando las variables son declaradas dentro de los metodos, siempre son locales al metodo.

public void ThisIsAMethod()
{
    string localVar;
}

En este caso, la variable localVar solo puede ser asignada y accedida dentro de este metodo, fuera de el no existe. Las funciones locales representan el mismo principio pero con metodos adentro de metodos.

Una funcion local se declara adentro de un metodo y solo puede ser accedida dentro de ese metodo, esto permite que la funcionalidad sea encapsulada en el metodo y favorece la limpieza del codigo.

public void ThisIsAMethod()
{
    
    string getStatus()
    {
        return isActive ? "Active" : "Inactive";
    }

    Console.WriteLine(getStatus());
}

Para el programador que lea la implementacion de este metodo, por ejemplo, sera evidente que cosas se supone que el metodo ejecute, ademas de dejar perfectamente claro que la funcion local solo es aplicable en el cotexto de este metodo y no en otro, digamo que su principal objetivo es organizar el codigo para hacerlos mas legible.

Las funciones locales como ven, se declaran como cualquier otro metodo pero sin el modificador de acceso dado que en este caso no aplica por que la funcion no podra accederse por fuera del metodo.

public void ThisIsAMethod()
{
    
    string getStatus()
    {
        return isActive ? "Active" : "Inactive";
    }

    Console.WriteLine(getStatus());
}

En este ejemplo el metodo getStatus(), es local al metodo ThisIsAMethod() por lo cual solo sera accedido y solo existirá dentro de ese metodo, por fuera de ese metodo no puede ser usado.


