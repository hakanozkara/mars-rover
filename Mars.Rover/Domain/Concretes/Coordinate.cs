using Mars.Rover.Domain.Enums;
using Mars.Rover.Domain.Abstracts;

namespace Mars.Rover.Domain.Concretes
{
    public class Coordinate : ICoordinate
    {
        public Coordinate(int x = 0, int y = 0) 
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
    }
}
