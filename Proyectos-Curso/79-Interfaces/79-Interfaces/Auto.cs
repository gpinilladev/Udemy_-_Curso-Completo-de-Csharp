using System;
namespace _79_Interfaces
{
    public class Auto : IVehicle
    {
        int speed;
        public void applyBrakes(int decrement)
        {
            speed = speed - decrement * 5;
        }

        public void speedUp(int increment)
        {
            speed = speed + increment * 5;
        }

        public void Print()
        {
            Console.WriteLine($"Speed: { speed }");
        }
    }
}

