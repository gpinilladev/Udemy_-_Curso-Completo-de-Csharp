using System;

namespace _73_Herencia
{

    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hola mundo");
            Animal animal = new Animal();
            animal.Saludar();
            Dog dog = new Dog();
            dog.Saludar();
            Cat cat = new Cat();
            cat.Saludar();
        }
    }

    public class Animal
    {
        public virtual void Saludar()
        {
            Console.WriteLine("Hello I am an animal!");
        }
    }

    class Dog : Animal
    {
        public override void Saludar()
        {
            Console.WriteLine("Hello I am a dog!");
        }
    }


    class Cat : Animal
    {
        
    }

}