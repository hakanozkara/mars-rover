using Mars.Rover.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Rover.Domain.Abstracts
{
    public interface ICoordinate
    {
        int X { get; set; }
        int Y { get; set; }
    }
}
