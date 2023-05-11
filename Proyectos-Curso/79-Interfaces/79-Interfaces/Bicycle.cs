using System;
namespace _79_Interfaces
{
    public class Bicycle : IVehicle
    {
        int speed;
        public void applyBrakes(int decrement)
        {
            speed = speed - decrement;
        }

        public void speedUp(int increment)
        {
            speed = speed + increment;
        }

        public void Print()
        {
            Console.WriteLine($"Speed: { speed }");
        }
    }
}

