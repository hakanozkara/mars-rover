using Mars.Rover.Domain.Abstracts;

namespace Mars.Rover.Domain.Concretes
{
    public class Surface : ISurface
    {
        public ICoordinate Coordinate { get; private set; }
        public Surface(ICoordinate position)
        {
            Coordinate = position;
        }
    }
}
