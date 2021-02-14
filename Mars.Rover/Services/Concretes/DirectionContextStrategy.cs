using Mars.Rover.Domain.Abstracts;
using Mars.Rover.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mars.Rover.Services.Concretes.DirectionStrategy
{
    public class DirectionContextStrategy : IDirectionContextStrategy
    {
        private readonly List<IDirectionStrategy> _turnStrategies;
        private IDirectionStrategy _turnStrategy;

        public DirectionContextStrategy()
        {
            _turnStrategies = new List<IDirectionStrategy> { new LeftDirectionStrategy(), new RightDirectionStrategy(), new MoveDirectionStrategy() };
        }

        public void SetCommand(string command)
        {
            if (command is null || string.IsNullOrEmpty(command) || string.IsNullOrWhiteSpace(command))
                throw new ArgumentNullException(nameof(command));

            _turnStrategy = _turnStrategies.FirstOrDefault(p => p.CommandKey.ToString() == command);
        }

        public IDirectionStrategy GetDirection()
        {
            return _turnStrategy;
        }
    }
}
