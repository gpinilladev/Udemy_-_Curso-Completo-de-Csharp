17 - NAMESPACES

Probablemente recuerdes la palabra clave "namespace" del hola mundo que hicimos al comienzo del curso. A decir verdad la palabra clave namespaces se encontrara en todos los archivos donde haya codigo c#, en general arriba de todo el documento.

Un namespace es escencialmente una manera de agrupar tipos y clases en un espacio en si mismo y con un nombre en particular.

En general un namespace contiene una o mas clases y no es mas que una forma de ordenarlas segun un cierto criterio. En otros lenguajes de programacion estos se conocen como paquetes, pero en c# llevan el nombre de namespaces.

Ejemplo de namespace:

namespace MyOffice {
    class Person{}
    class Employee{}
    class Manager{}
}

namespace MyProduct {
    class Product{}
    class ProdcutItem{}
    class Order{}
}

Ya veremos en la practica como se importan namespaces, pero por ahora bastara con saber que cuando queremos usar una clase que pertenece a un namespace especifico desde otro namespace, entonces tendremos que agregar arriba de todo nuestro archivo la palabra clave using seguida del nombre del namespace.

namespace MyOffice {
    class Person{}
    class Employee{}
    class Manager{}
}

using MyOffice;
namespace MyProduct {
    class Product{}
    class ProdcutItem{}
    class Order{}
}

* Namespaces Alias
Muchas veces sucedera que el namespace es demasiado largo y es incomodo utilizarlo asi dentro del codigo, por ejemplo digamos que vamos a utilizar la libreria Serialization que forma parte del framework. 

Este seria el using:

using System.Web.Script.Serialization;

La forma de usarla dentro del codigo, para dar un ejemplo se veria algo asi:

var js = new System.Web.Script.Serialization.JavaScriptSerializer();

Como vemos el uso de esta libreria es muy largo en su implentacion y es por eso que c# introduce el concepto de alias, que nos permite ponerle un nombre abreviado al namespace dentro del using logrando hacer algo como lo siguiente:

using JS = System.Web.Script.Serialization;

Y entonces cuando necesitemos usar este mismo namespace, ahora solo seria necesario utilizar su forma abreviada:

var js = new JS.JavaScriptSerializer();

Es muy normal que en proyectos complejos con muchos modulos y clases, el nombre de los namespaces sea demasiado largo, es en estos casos en donde usamos los alias.
