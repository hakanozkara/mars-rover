using Mars.Rover.Domain.Abstracts;
using Mars.Rover.Domain.Concretes;
using Mars.Rover.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Rover.Services.Concretes
{
    public class SurfaceFactory : ISurfaceFactory
    {
        public ISurface Surface { get; private set; }

        public void CreateSurface(ICoordinate coordinate)
        {
            if (coordinate is null)
                throw new ArgumentNullException(nameof(coordinate));

            if (coordinate.X < 0)
                throw new ArgumentOutOfRangeException($"Field {nameof(coordinate.X)} cannot be below 0");

            if (coordinate.Y < 0)
                throw new ArgumentOutOfRangeException($"Field {nameof(coordinate.Y)} cannot be below 0");

            Surface = new Surface(coordinate);
        }

    }
}
