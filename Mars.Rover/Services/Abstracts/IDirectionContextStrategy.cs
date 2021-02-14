using System;
using System.Collections.Generic;
using System.Text;

namespace Mars.Rover.Services.Abstracts
{
    public interface IDirectionContextStrategy
    {
        void SetCommand(string command);
        IDirectionStrategy GetDirection();
    }
}
