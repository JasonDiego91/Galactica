using System;
using static Galactica.SpaceObject;


namespace Galactica
{
    class Program
    {

        static void Main(string[] args)
        {
            Star sun = new Star()
            {
                Id = 1,
                Name = "Sun",
                Type = StarType.YellowDwarf.ToString(),
                Temperature = 5500

            };
            Planet mercury = new Planet()
            {
                Id = 1,
                Name = "Mercury",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 4880000,
                RotationPeriod = 1407,
                RevolutionPeriod = 176,

            };
            Planet venus = new Planet()
            {
                Id = 2,
                Name = "Venus",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 6051800,
                RotationPeriod = 5832,
                RevolutionPeriod = 116
            };
            Planet earth = new Planet()
            {
                Id = 3,
                Name = "Earth",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 12742000,
                RotationPeriod = 24,
                RevolutionPeriod = 365
            };
            Planet mars = new Planet()
            {
                Id = 4,
                Name = "Mars",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 6779000,
                RotationPeriod = 25,
                RevolutionPeriod = 687
            };
            Planet jupiter = new Planet()
            {
                Id = 5,
                Name = "Jupiter",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 139820000,
                RotationPeriod = 10,
                RevolutionPeriod = 4300,

            };
            Planet saturn = new Planet()
            {
                Id = 6,
                Name = "Saturn",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 116460000,
                RotationPeriod = 10.2,
                RevolutionPeriod = 11000
            };
            Planet uranus = new Planet()
            {
                Id = 7,
                Name = "Uranus",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 50724000,
                RotationPeriod = 17,
                RevolutionPeriod = 30660
            };
            Planet neptune = new Planet()
            {
                Id = 8,
                Name = "Neptune",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 49244000,
                RotationPeriod = 16.1,
                RevolutionPeriod = 164.8
            };

            Moon luna = new Moon()
            {
                Id = 1,
                Name = "Luna",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 49244000,
                RotationPeriod = 16.1,
                RevolutionPeriod = 164.8
            };
            Moon titan = new Moon()
            {
                Id = 2,
                Name = "Titan",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 49244000,
                RotationPeriod = 16.1,
                RevolutionPeriod = 164.8
            };
            Moon phobos = new Moon()
            {
                Id = 3,
                Name = "Phobos",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 49244000,
                RotationPeriod = 16.1,
                RevolutionPeriod = 164.8
            };
            Moon europe = new Moon()
            {
                Id = 4,
                Name = "Europe",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 49244000,
                RotationPeriod = 16.1,
                RevolutionPeriod = 164.8
            };
            Moon deimos = new Moon()
            {
                Id = 5,
                Name = "Deimos",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 49244000,
                RotationPeriod = 16.1,
                RevolutionPeriod = 164.8
            };
            Moon ganymedes = new Moon()
            {
                Id = 6,
                Name = "Ganymedes",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 49244000,
                RotationPeriod = 16.1,
                RevolutionPeriod = 164.8
            };
            Moon io = new Moon()
            {
                Id = 7,
                Name = "Io",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 49244000,
                RotationPeriod = 16.1,
                RevolutionPeriod = 164.8
            };
            Moon mimas = new Moon()
            {
                Id = 8,
                Name = "Mimas",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 49244000,
                RotationPeriod = 16.1,
                RevolutionPeriod = 164.8
            };

            sun.planetList.Add(mercury);
            sun.planetList.Add(venus);
            sun.planetList.Add(earth);
            sun.planetList.Add(mars);
            sun.planetList.Add(jupiter);
            sun.planetList.Add(saturn);
            sun.planetList.Add(uranus);
            sun.planetList.Add(neptune);

            earth.moonList.Add(luna);
            saturn.moonList.Add(titan);
            saturn.moonList.Add(mimas);
            mars.moonList.Add(phobos);
            mars.moonList.Add(deimos);
            jupiter.moonList.Add(europe);
            jupiter.moonList.Add(ganymedes);
            jupiter.moonList.Add(io);

            foreach (var Planet in sun.planetList)
            {
                Console.WriteLine($"Id: {Planet.Id}\n" + $"Name: {Planet.Name}\n" + $"Type: {Planet.Type}\n" + $"Diameter i meter: {Planet.Diameter}");
                foreach (var Moon in Planet.moonList)
                {
                    Console.WriteLine($"\tId: {Moon.Id}\n" + $"\tName: {Moon.Name}\n" + $"\tType: {Moon.Type}");
                }
            }
        }
    }
}
