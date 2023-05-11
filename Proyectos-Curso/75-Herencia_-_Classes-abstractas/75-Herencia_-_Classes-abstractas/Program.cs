using System;

namespace _75_Herencia_Clases_Abstractas {
    class Program
    {
        static void Main(string[] args)
        {

            //Animal animal = new Animal();
            //animal.Saludar();
            Dog dog = new Dog();
            dog.Saludar();
            Cat cat = new Cat();
            cat.Saludar();

        }
    }

    public abstract class Animal
    {
        //public virtual void Saludar()
        //{
        //    Console.WriteLine("Hi, I'm an animal!");
        //}
        public abstract void Saludar();
    }

    class Dog : Animal
    {
        public override void Saludar()
        {
            Console.WriteLine("Hi, I'm a dog!");
        }
    }

    class Cat : Animal
    {
        public override void Saludar()
        {
            Console.WriteLine("Hi, I'm a cat!");
        }
    }

}