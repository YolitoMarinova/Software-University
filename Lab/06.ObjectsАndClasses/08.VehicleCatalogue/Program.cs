using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.VehicleCatalogue
{
    class Program
    {
        static void Main()
        {
            string[] command = Console.ReadLine().Split('/');

            Catalog catalog = new Catalog();

            while (command[0] != "end")
            {
                if (command[0] == "Truck")
                {
                    string brand = command[1];
                    string model = command[2];
                    int weight = int.Parse(command[3]);

                    Truck truck = new Truck();

                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weight;

                    catalog.Trucks.Add(truck);


                }
                else if (command[0] == "Car")
                {
                    string brand = command[1];
                    string model = command[2];
                    int horsePower = int.Parse(command[3]);

                    Car car = new Car();

                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower = horsePower;

                    catalog.Cars.Add(car);

                }
                command = Console.ReadLine().Split('/');
            }

            if (catalog.Cars.Count>0)
            {
                Console.WriteLine("Cars:");

                var descendingHP = catalog.Cars.OrderBy(x => x.Brand);
                foreach (var car in descendingHP)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                var descendingW = catalog.Trucks.OrderBy(x => x.Brand);
                foreach (var truck in descendingW)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }
}

class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}

class Catalog
{
    public Catalog()
    {
        Trucks = new List<Truck>();
        Cars = new List<Car>();
    }

    public List<Truck> Trucks { get; set; }
    public List<Car> Cars { get; set; }
}

