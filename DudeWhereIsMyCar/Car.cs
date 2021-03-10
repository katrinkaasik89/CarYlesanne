using System;
using System.Collections.Generic;
using System.Text;

namespace DudeWhereIsMyCar
{
    class Car
    {
        public string markName;
        public string modelName;
        public string registrationNumber;
        public string color;
        public int odometer;
        public int fuelTank;
        public int numberOfLaps;

        public void PrintCarInfo()
        {
            Console.WriteLine($"Auto mark: {markName}, mudel: {modelName}, registrinr: {registrationNumber}, v2rv: color, odomeetrin2it:{odometer}, kytusehulk:{fuelTank}");
                }

        


        public Car(string _markName, string _modelName, string _registrationNumber, string _color, int _odometer, int _fuelTank)

        {
            markName = _markName;
            modelName = _modelName;
            registrationNumber = _registrationNumber;
            color = _color;
            odometer = 0;
            fuelTank = 60;            

        }
        public void drive()
        {
            numberOfLaps =+1;
            odometer =+100;
            fuelTank =-5;
            Console.WriteLine($"Ringe tehtud: {numberOfLaps}, odomeetrin2it nyyd: {odometer}, kytuse hulk: {fuelTank});
                }

    }
}

    

