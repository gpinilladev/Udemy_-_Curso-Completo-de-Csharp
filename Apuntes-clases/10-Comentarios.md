10 - Comentarios

A simple vista esta puede ser una leccion menor, pero ser capaz de comentar apropiadamente tu codigo, es una de las mas acertadas buenas practicas de la programacion. Ten en cuenta que en la programacion profesional, ya sea que se trabaje para una empresa o determinado proyecto personal, es muy poco proble que seamos la unica persona que toque el codigo. Lo mas comun es que el codigo que escribamos, esa leido e interpretado por muchos programadores, ademas nosotros mismos tendremos que leer codigo que otros programadores hayan escrito y en ese momento agradeceremos que se encuentre bien comentado.

Es por eso que acompañar la logica con un comentario que sea relevante, es una practica que siempre es bueno adoptar desde el principio.

En c# tenemos varias alternativas para agregar comentarios segun lo que sea que estamos intentando comentar. El mas comun y el que mas se usa es el comentario de una linea, este comentario se concigue con dos slash (//), todo lo que sigue despues de las dos barras, no sera interpretado por el compilador.

    int x = 10; // Este es un comentario de una sola linea
    // This is a comment

Pero si lo que se necesita es comentar mas de una linea, entonces lo que se necesita es usar el tipo de comentario multilinea. Para este tipo de comentario, en lugar de usar la doble barra, vamos a usar una secuencia de caracteres para abrir y una secuencia de caracteres para cerrar, y lo que este en el medio sera tratado como comentario sin importar cuantas lineas ocupe.

    /*
        * Comment Block
        int a = 10;
        int b = 20;
    */

Tambien disponemos de los comentarios tipo xml, estos son comentarios que se ven exactamente como los otros, pero que ademas tiene codigo xml embebido el cual en dos tags <summary> y </summary> podremos escribir el comentario que deseemos de la instruccion de codigo que queremos informar

    /// <summary>
    /// 
    /// </summary>

Ejemplo: 

using System;
namespace _10_Comentarios
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Comment xml
        /// </summary>
        /// <param name="args">This is about arguments</param>
        static void Main(string[] args)
        {
            int x = 10; // This a comment
            // int y = 20; Other comment

            /*
             * Comment Block
            int a = 10;
            int b = 20;
            */
            // TODO: Test comment
            // HACK
            // NOTE

        }
    }
}
