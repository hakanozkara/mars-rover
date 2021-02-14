using Mars.Rover.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Rover.Services.Abstracts
{
    public interface ISurfaceFactory
    {
        ISurface Surface { get; }
        void CreateSurface(ICoordinate coordinate);
    }
}
