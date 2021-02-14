using Mars.Rover.Domain.Abstracts;
using Mars.Rover.Services.Abstracts;
using System;

namespace Mars.Rover.Services.Concretes
{
    public class Rover : IRover
    {
        public ISurface Surface { get; set; }
        public IRoverPosition Position { get; set; }
        public IDirectionContextStrategy DirectionContextStrategy { get; set; }

        public Rover(ISurface surface, IRoverPosition position, IDirectionContextStrategy directionContextStrategy)
        {
            Surface = surface;
            Position = position;
            DirectionContextStrategy = directionContextStrategy;
        }

        public void Execute(string commands)
        {
            foreach (var command in commands)
            {
                DirectionContextStrategy.SetCommand(command.ToString());
                var strategy = DirectionContextStrategy.GetDirection();
                if (strategy == null)
                    throw new ArgumentOutOfRangeException($"{command} is invalid command value.");

                Position = strategy.Process(Surface, Position);
            }
        }

        public override string ToString()
        {
            return $"{Position.X} {Position.Y} {Position.Direction}";
        }
    }
}
