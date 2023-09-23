using System;

namespace CarNamespace
{
    public class Car
    {
        public enum FuelType
        {
            Gasoline,
            Diesel,
            Electric,
            Hybrid
        }
        public string RegistrationNo { get; set; }
        public string Model { get; set; }
        public FuelType CarFuelType { get; set; }
        public Wheel[] Wheels { get; }
        public Engine CarEngine { get; }
        public Car(string registrationNo, string model, FuelType fuelType)
        {
            RegistrationNo = registrationNo;
            Model = model;
            CarFuelType = fuelType;
            Wheels = new Wheel[4];
            CarEngine = new Engine();   
            for (int i = 0; i < 4; i++)
            {
                Wheels[i] = new Wheel();
            }
            
        }

        public class Wheel
        {
            public int Size { get; set; }
            public string Brand { get; set; }
        }

        public class Engine
        {
            public string Type { get; set; }
            public string Horsepower { get; set; }    
        }
    }
    class Testprogram
    {
      public static void CarTest()
        {
            Car myCar = new Car("AP05MX5845", "KIA", Car.FuelType.Gasoline);
            myCar.CarEngine.Type = "V6";
            myCar.CarEngine.Horsepower = "2000";
            myCar.Wheels[0].Size = 18;
            myCar.Wheels[0].Brand = "MRF";

            
            Console.WriteLine($"Car Registration No: {myCar.RegistrationNo}");
            Console.WriteLine($"Car Model: {myCar.Model}");
            Console.WriteLine($"Car Fuel Type: {myCar.CarFuelType}");
            Console.WriteLine($"Engine Type: {myCar.CarEngine.Type}");
            Console.WriteLine($"Engine Horsepower: {myCar.CarEngine.Horsepower}");
            Console.WriteLine($"Wheel Size: {myCar.Wheels[0].Size}");
            Console.WriteLine($"Wheel Brand: {myCar.Wheels[0].Brand}");

        }
    }
}



