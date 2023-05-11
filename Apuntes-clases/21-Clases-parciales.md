21 - CLASES PARCIALES

Una de las posibilidades que c# ofrece a la hora de trabajar con clases muy complejas o muy largas, es la de utilizar clases parciales, cuando una clase es definida con la palabra clave partial entonces esa clase puede ser extendida en otra clase que tambien debe ser declarada como parcial. 

Ejemplo de una clase parcial:

namespace Partials
{
    partial class Car
    {
        public string SpeedUp()
        {
            return "Acelerate";
        }
    }
}

Aqui tenemos un ejemplo de la clase Car definida como parcial, es una clase igual que otras que ya habiamos visto y tiene un unico metodo llamado SpeedUp(). La ventaja que ofrece el haber agregado la palabra clave partial, es que tambien podemos tener otro archivo con otra definicion de la clase de la siguiente forma.

namespace Partials
{
    partial class Car
    {
        public string SlowDown()
        {
            return "Not so fast!";
        }
    }
}

Podemos ver que tenemos otra clase parcial con el mismo nombre pero con un metodo distinto, de esta forma tenermos dos clases diferentes con el mismo nombre y la palabra clave partial, o lo que es lo mismo que decir, dos partes separadas de la misma clase.

Usar la clase car que vimos recien, no sera diferente a lo que estabamos acostumbrados, de hecho a la hora de instanciar la clase, para le compilador solo existe una clase y no hay ninguna diferencia visible entre clases parciales y clases no parciales. En tiempo de desarrollo, tendremos acceso a todos los metodos y propiedades de todas las partes de la clase desede su instancia. Digamos que en un sentido mas general, las clases parciales nos permiten organizar el codigo de clases complejas, muy extensas pero no tienen ningun impacto real de la forma en la cual las clases funcionan, es meramente organizacional si asi se quiere.

namespace Partials
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.SpeedUp();
            car.SlowDown();
        }
    }
}