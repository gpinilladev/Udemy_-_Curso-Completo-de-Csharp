using System;
namespace _79_Interfaces
{
    public class Program
    {
        internal static void Main()
        {
            int increment = 10;
            int decrement = 5;

            Bicycle bicycle = new Bicycle();
            bicycle.speedUp(increment);
            bicycle.applyBrakes(decrement);
            bicycle.Print();

            Auto auto = new Auto();
            auto.speedUp(increment);
            auto.applyBrakes(decrement);
            auto.Print();
        }
    }
}