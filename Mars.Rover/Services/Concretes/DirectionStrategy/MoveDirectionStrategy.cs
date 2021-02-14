using Mars.Rover.Domain.Abstracts;
using Mars.Rover.Domain.Enums;
using Mars.Rover.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Rover.Services.Concretes.DirectionStrategy
{
    public class MoveDirectionStrategy : IDirectionStrategy
    {
        public Command CommandKey => Command.M;

        public IRoverPosition Process(ISurface surface, IRoverPosition roverPosition)
        {
            switch (roverPosition.Direction)
            {
                case Direction.N:
                    roverPosition.Y = roverPosition.Y + 1 > surface.Coordinate.Y ? roverPosition.Y : roverPosition.Y + 1;
                    return roverPosition;
                case Direction.E:
                    roverPosition.X = roverPosition.X + 1 > surface.Coordinate.X ? roverPosition.X : roverPosition.X + 1;
                    return roverPosition;
                case Direction.S:
                    roverPosition.Y = roverPosition.Y - 1 < 0 ? roverPosition.Y : roverPosition.Y - 1;
                    return roverPosition;
                case Direction.W:
                    roverPosition.X = roverPosition.X - 1 < 0 ? roverPosition.X : roverPosition.X - 1;
                    return roverPosition;
            }

            return roverPosition;
        }
    }
}
