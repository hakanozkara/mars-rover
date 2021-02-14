using Mars.Rover.Domain.Abstracts;
using Mars.Rover.Domain.Enums;
using Mars.Rover.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Rover.Services.Concretes.DirectionStrategy
{
    public class LeftDirectionStrategy : IDirectionStrategy
    {
        public Command CommandKey => Command.L;

        public IRoverPosition Process(ISurface surface, IRoverPosition roverPosition)
        {
            roverPosition.Direction = roverPosition.Direction - 1 < Direction.N ? Direction.W : roverPosition.Direction - 1;
            return roverPosition;
        }
    }
}
