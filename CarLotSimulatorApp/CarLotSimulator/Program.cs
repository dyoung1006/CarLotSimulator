using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            CarLot lot = new CarLot();

            Car jeep = new Car();
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");
            lot.CarList.Add(jeep);

            jeep.Year = 2019;
            jeep.Make = "Jeep";
            jeep.Model = "Cherokee";
            jeep.EngineNoise = "None";
            jeep.HonkNoise = "Move Bi&tch";
            jeep.IsDriveable = true;

            jeep.MakeEngineNoise();
            jeep.MakeHonkNoise();

            Car kia = new Car() { Year = 2011, Make = "Kia", Model = "Optima", EngineNoise = "Cya", HonkNoise = "SlowMo" };
            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            lot.CarList.Add(kia);
            Car ford = new Car(1960, "Ford", "F-150", "guzzling", "circus noise");
            CarLot.numberOfCars++;   //incrementing the car lot when calling with the above method since the constructor is not called this way.

            Console.WriteLine($"Number of cars created: {CarLot.numberOfCars}");

            lot.CarList.Add(ford);
            ford.MakeEngineNoise();
            ford.MakeHonkNoise();

            

            foreach (var car in lot.CarList)
            {
                Console.WriteLine($"Make:{car.Make}, Model:{car.Model}, Year:{car.Year}");
            }

            Console.Read();

        }
    }
}
