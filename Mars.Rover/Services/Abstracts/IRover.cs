using Mars.Rover.Domain.Abstracts;

namespace Mars.Rover.Services.Abstracts
{
    public interface IRover
    {
        ISurface Surface { get; set; }
        IRoverPosition Position { get; set; }
        IDirectionContextStrategy DirectionContextStrategy { get; set; }
        void Execute(string commands);
        string ToString();
    }

}
