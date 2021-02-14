using Mars.Rover.Domain.Concretes;
using Mars.Rover.Domain.Enums;
using Mars.Rover.Services.Concretes.DirectionStrategy;
using System;

namespace Mars.Rover
{
    class Program
    {
        static void Main(string[] args)
        {
            Surface surface = new Surface(new Coordinate(5, 5));
            var firstRover = new Mars.Rover.Services.Concretes.Rover(surface, new RoverPosition(1, 2, Direction.N), new DirectionContextStrategy());
            firstRover.Execute("LMLMLMLMM");

            Console.WriteLine($"firstRover: {firstRover.ToString()}");

            var secondRover = new Mars.Rover.Services.Concretes.Rover(surface, new RoverPosition(3, 3, Direction.E), new DirectionContextStrategy());
            secondRover.Execute("MMRMMRMRRM");
            Console.WriteLine($"secondRover: {secondRover.ToString()}");


        }
    }
}
