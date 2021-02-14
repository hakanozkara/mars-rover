using Mars.Rover.Domain.Abstracts;
using Mars.Rover.Domain.Enums;
using Mars.Rover.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Rover.Services.Concretes.DirectionStrategy
{
    public class RightDirectionStrategy : IDirectionStrategy
    {
        public Command CommandKey => Command.R;

        public IRoverPosition Process(ISurface surface, IRoverPosition roverPosition)
        {
            roverPosition.Direction =  roverPosition.Direction + 1 > Direction.W ? Direction.N : roverPosition.Direction + 1;
            return roverPosition;
        }
    }
}
