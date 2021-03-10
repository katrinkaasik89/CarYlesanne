using System;

namespace DudeWhereIsMyCar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Ford = new Car("Ford", "Mustang", "KJH543", "Black", 0, 60);
                Ford.PrintCarInfo();
            do
            {
                Ford.drive();
                
            }
            while
            (Ford.fuelTank==0);
            Console.WriteLine("Kytus otsas, rohkem s6ita ei saa!");
        }
    }
}
