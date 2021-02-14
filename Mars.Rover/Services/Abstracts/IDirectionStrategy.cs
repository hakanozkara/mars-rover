using Mars.Rover.Domain.Abstracts;
using Mars.Rover.Domain.Enums;

namespace Mars.Rover.Services.Abstracts
{
    public interface IDirectionStrategy
    {
        Command CommandKey { get; }
        IRoverPosition Process(ISurface surface, IRoverPosition roverPosition);
    }
}
