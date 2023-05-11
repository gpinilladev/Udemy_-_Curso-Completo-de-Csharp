06 - Conversion de tipos de datos

Como ya vimos en lecciones anteriores, c# es un lenguaje fuertemente tipado lo que significa que despues de declarar una variable y definir su tipo de datos, esa variable no se puede volver a declarar ni se le puede asignar un valor de otro tipo de datos, a menos que este sea convertible de forma implicita.

Por ejemplo, un string no se puede convertir de forma implicita a int, por lo cual una variable declarada como int, no se le puede asignar una cadena de texto.

    int number;
    number = "Larry David";  // Esto daria un error de compilacion => Error: Cannot implicitly convert type 'string' to 'int'

Pero aveces si que necesitamos copiar en una variable, el valor de otra variable de otro tipo, especialmente cuando sabemos que la conversion es posible.

Por ejemplo, cuando el valor string es efectivamente un entero:

    string number = "1234";

Para realizar converesiones de tipo en c#, tenemos cuatro alternativas:
    *  Conversiones implicitas: Un conversion implicita no requiere ninguna sintaxis en especial, porque no se perdera ningun dato. En general las conversiones implicitas se realizan de numeros enteros pequeños a tipos enteros mas grandes. Ejemplo:

        int 32 bits;
        long 64 bits;

        int number = 123456;
        long bigNumber = number;

    * Conversiones explicitas: Son las que requieren lo que se conoce como casteo, que es basicamente una expresion cast. Esta conversion es necesaria siempre que haya un riesgo de que se pierda informacion en la conversion o cuando puede que la conversion falle por otros motivos. Un ejemplo tipico seria la conversion de un valor con un tipo de datos muy preciso, como podria ser un decimal,a uno con mucha menos preciosion como un float. Ejemplo:

        long number = 123456;
        int secondNumber = number; // Error
        int secondNumber = (int)number; // Conversion explicita con cast

    * Conversiones definidas por el usuario: Son metodos o funciones escritos por el usuario para realizar conversiones entre tipos de datos que en principio son incompatibles. Consiste basicamente en crear un metodo que reciba cierto tipo de datos por parametros escribir logica para transformar ese tipo de datos en uno nuevo estableciendo nuestras propias reglas y luego devolver el nuevo tipo de datos en nuestra funcion.

    * Conversiones con clases del asistente: Que se utilizan para realizar conversiones entre tipos de datos no compatibles, como pueden ser enteros y otros objetos. Para esto se utilian clases como: 

        System.convert
        System.bitconverter
        Metodos parse de los tipos numericos integrados

        string txtNumber = "1234";

        // Parse / TryParse
        int number = Int32.Parse(txtNumber);
        bool validCast = Int32.tryParse();

        // System.Convert
        int number = Convert.ToInt32(txtNumber);
