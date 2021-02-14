using Mars.Rover.Domain.Abstracts;
using Mars.Rover.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Rover.Domain.Concretes
{
    public class RoverPosition : IRoverPosition
    {
        public RoverPosition(int x = 0, int y = 0, Direction direction = Direction.N)
        {
            if (x < 0)
                throw new ArgumentOutOfRangeException($"Field {nameof(x)} cannot be below 0");

            if (y < 0)
                throw new ArgumentOutOfRangeException($"Field {nameof(y)} cannot be below 0");

            if (direction <= 0)
                throw new ArgumentOutOfRangeException($"Field {nameof(direction)} cannot be below 0");

            X = x;
            Y = y;
            Direction = direction;
        }
        public Direction Direction { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    }
}
