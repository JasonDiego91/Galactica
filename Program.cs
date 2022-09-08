using System;
using static Galactica.SpaceObject;


namespace Galactica
{
    class Program
    {
        //Main program and startup with all relevent data shown
        static void Main(string[] args)
        {

            Star sun = new Star()
            {
                Id = 1,
                Name = "SUN",
                Type = StarType.YellowDwarf.ToString(),
                Temperature = 5500

            };
            Planet mercury = new Planet()
            {
                Id = 1,
                Name = "MERCURY",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 4880000,
                RotationPeriod = 1407,
                RevolutionPeriod = 176,

            };
            Planet venus = new Planet()
            {
                Id = 2,
                Name = "VENUS",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 6051800,
                RotationPeriod = 5832,
                RevolutionPeriod = 116
            };
            Planet earth = new Planet()
            {
                Id = 3,
                Name = "EARTH",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 12742000,
                RotationPeriod = 24,
                RevolutionPeriod = 365
            };
            Planet mars = new Planet()
            {
                Id = 4,
                Name = "MARS",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 6779000,
                RotationPeriod = 25,
                RevolutionPeriod = 687
            };
            Planet jupiter = new Planet()
            {
                Id = 5,
                Name = "JUPITER",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 139820000,
                RotationPeriod = 10,
                RevolutionPeriod = 4300,

            };
            Planet saturn = new Planet()
            {
                Id = 6,
                Name = "SATURN",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 116460000,
                RotationPeriod = 10.2,
                RevolutionPeriod = 11000
            };
            Planet uranus = new Planet()
            {
                Id = 7,
                Name = "URANUS",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Terrestial,
                Diameter = 50724000,
                RotationPeriod = 17,
                RevolutionPeriod = 30660
            };
            Planet neptune = new Planet()
            {
                Id = 8,
                Name = "NEPTUNE",
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
                Type = PlanetType.Moon,
                Diameter = 3474.8,
                RotationPeriod = 27,
                RevolutionPeriod = 27
            };
            Moon titan = new Moon()
            {
                Id = 2,
                Name = "TITAN",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Moon,
                Diameter = 5149.5,
                RotationPeriod = 15.9,
                RevolutionPeriod = 16
            };
            Moon phobos = new Moon()
            {
                Id = 3,
                Name = "PHOBOS",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Moon,
                Diameter = 22.533,
                RotationPeriod = 0.32,
                RevolutionPeriod = 8
            };
            Moon europe = new Moon()
            {
                Id = 4,
                Name = "EUROPE",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Moon,
                Diameter = 3.1216,
                RotationPeriod = 3.5,
                RevolutionPeriod = 85
            };
            Moon deimos = new Moon()
            {
                Id = 5,
                Name = "DEIMOS",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Moon,
                Diameter = 12.4,
                RotationPeriod = 30,
                RevolutionPeriod = 30
            };
            Moon ganymedes = new Moon()
            {
                Id = 6,
                Name = "GANYMEDE",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Moon,
                Diameter = 5.2682,
                RotationPeriod = 10.880,
                RevolutionPeriod = 172
            };
            Moon io = new Moon()
            {
                Id = 7,
                Name = "IO",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Moon,
                Diameter = 3.6432,
                RotationPeriod = 17.334,
                RevolutionPeriod = 42
            };
            Moon mimas = new Moon()
            {
                Id = 8,
                Name = "MIMAS",
                position = (new SpaceObject.Position() { X = 0, Y = 0 }),
                Type = PlanetType.Moon,
                Diameter = 396.4,
                RotationPeriod = 14.28,
                RevolutionPeriod = 23
            };
            // Planets and moons added to list

            earth.moonList.Add(luna);
            saturn.moonList.Add(titan);
            saturn.moonList.Add(mimas);
            mars.moonList.Add(phobos);
            mars.moonList.Add(deimos);
            jupiter.moonList.Add(europe);
            jupiter.moonList.Add(ganymedes);
            jupiter.moonList.Add(io);

            sun.planetList.Add(mercury);
            sun.planetList.Add(venus);
            sun.planetList.Add(earth);
            sun.planetList.Add(mars);
            sun.planetList.Add(jupiter);
            sun.planetList.Add(saturn);
            sun.planetList.Add(uranus);
            sun.planetList.Add(neptune);



            // Output of the relevent data and its visual format on screen
            foreach (var Planet in sun.planetList)
            {
                Console.WriteLine($"\tId: {Planet.Id}\n\n" + $"\tName: {Planet.Name}\n" + $"\tType: {Planet.Type}\n" + $"\tDiameters in meters: {Planet.Diameter}\n");
                foreach (var Moon in Planet.moonList)
                {
                    Console.WriteLine($"\tId: {Moon.Id}\n\n" + $"\tName: {Moon.Name}\n" + $"\tType: {Moon.Type}\n" + $"\tMoon Diameter: {Moon.Diameter}\n");
                }
            }
        }
    }
}
