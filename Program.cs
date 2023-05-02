using System;

namespace Properties_Babcock_Olivia
{
    class Program
    {
        static void Main(string[] args)
        {   // Creates a car
            Car car = new Car();
            // Assigns a model and make to the car
            car.Make = "Toyota";
            car.Model = "Tundra";

            // Prints model and make to the console
            Console.WriteLine($"Make: {car.Make}, Model: {car.Model}");

            // Creates a car
            Car car2 = new Car();
            // Assigns a model and make to the car
            car2.Make = "Infiniti";
            car2.Model = "SUV";

            // Prints model and make to the console
            Console.WriteLine($"Make: {car2.Make}, Model: {car2.Model}");

            // Creates a car
            Car car3 = new Car();

            // Prints model and make to the console
            Console.WriteLine($"Make: {car3.Make}, Model: {car3.Model}");
        }
    }
}
