using Mars.Rover.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Rover.Domain.Abstracts
{
    public interface IRoverPosition : ICoordinate
    {
        Direction Direction { get; set; }
    }
}
