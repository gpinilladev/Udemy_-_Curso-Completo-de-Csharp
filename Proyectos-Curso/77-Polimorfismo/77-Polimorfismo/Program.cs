using System;
namespace _77_Polimorfismo
{
    class Program
    {
        internal static void Main()
        {
            var shapes = new List<Shape>();

            Square square = new Square();
            // square.Height = 10;
            square.Width = 10;
            //double areaSquare = square.CalculateArea();
            //Console.WriteLine($"El area del cuadrado es: { areaSquare }");

            Rectangle rectangle = new Rectangle();
            rectangle.Height = 10;
            rectangle.Width = 20;
            //var areaRectangle = rectangle.CalculateArea();
            //Console.WriteLine($"El area del rectangulo es: { areaRectangle }");

            Triangle triangle = new Triangle();
            triangle.Height = 15;
            triangle.Width = 10;
            //var areaTriangle = triangle.CalculateArea();
            //Console.WriteLine($"El area del triangulo es: { areaTriangle }");

            shapes.Add(rectangle);
            shapes.Add(triangle);
            shapes.Add(square);

            foreach (Shape item in shapes)
            {
                Console.WriteLine($"Area: { item.CalculateArea() }");
            }

        }
    }


    public abstract class Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public abstract double CalculateArea();
    }

    public class Square : Shape
    {
        public override double CalculateArea()
        {
            return Math.Pow(Width, 2);
        }
    }

    public class Rectangle : Shape
    {
        public override double CalculateArea()
        {
            return this.Height * this.Width;
        }
    }

    public class Triangle : Shape
    {
        public override double CalculateArea()
        {
            return (this.Width * this.Height) / 2;
        }
    }

}