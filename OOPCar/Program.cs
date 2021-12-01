using System;

namespace OOPCar
{
    class Program
    {
        class Car
        {
            string MarkName;
            string ModelName;
            string registrationNumber;
            string color;
            int Odometer;
            int Fuel;

            public Car(string _name,string _model,string _RegistrationNumber,string _color)
            {
                MarkName = _name;
                ModelName = _model;
                registrationNumber = _RegistrationNumber;
                color = _color;
                Odometer = 0;
                Fuel = 60;

                Console.WriteLine($"Your {color} {MarkName} {ModelName} {registrationNumber} has been arrived!");
            }
            public string Model
            {
                get { return ModelName; }
            }
            public string Mark
            {
                get { return MarkName; }
            }
            public string Color
            {
                get { return color; }
            }
            public string RegitrationNumber
            {
                get { return registrationNumber; }
            }
            public int Odo
            {
                get { return Odometer; }
            }
            public int FuelTank
            {
                get { return Fuel; }
            }
            public void Drive()
            {
                Fuel -= 5;
                Odometer += 100;
                Console.WriteLine("Wroom Wroom!");
            }

            public void ShowCarInfo()
            {
                Console.WriteLine($"Mark Name: {MarkName}.");
                Console.WriteLine($"Model Name: {ModelName}.");
                Console.WriteLine($"Registration Number: {registrationNumber}.");
                Console.WriteLine($"Color: {Color}.");
                Console.WriteLine($"Odometer: {Odometer}.");
                Console.WriteLine($"Fuel Tank: {Fuel}.");
                GC.Collect();
            }
  
        }
        static void Main(string[] args)
        {
            Car myCar = new Car("BMW", "M4", "HUT722", "Yellow");

            while(myCar.FuelTank > 0)
            {
                myCar.Drive();
            }

            myCar.ShowCarInfo();
        }
    }
}
