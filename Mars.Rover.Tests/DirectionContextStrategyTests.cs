using Mars.Rover.Services.Abstracts;
using Mars.Rover.Services.Concretes.DirectionStrategy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mars.Rover.Tests
{
    public class DirectionContextStrategyTests
    {
        [Theory]
        [InlineData("L")]
        [InlineData("R")]
        [InlineData("M")]
        public void IsNotNull_DirectionStrategy(string command)
        {
            IDirectionContextStrategy directionContextStrategy = new DirectionContextStrategy();

            directionContextStrategy.SetCommand(command);
            IDirectionStrategy directionStrategy = directionContextStrategy.GetDirection();

            Assert.NotNull(directionStrategy);
        }

        [Theory]
        [InlineData("K")]
        [InlineData("A")]
        [InlineData("U")]
        public void IsNull_DirectionStrategy(string command)
        {
            IDirectionContextStrategy directionContextStrategy = new DirectionContextStrategy();

            directionContextStrategy.SetCommand(command);
            IDirectionStrategy directionStrategy = directionContextStrategy.GetDirection();

            Assert.Null(directionStrategy);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void IsThrowArgumentOutOfRangeException_Coordinate_X_and_Y_Minus(string command)
        {
            IDirectionContextStrategy directionContextStrategy = new DirectionContextStrategy();

            Assert.Throws<ArgumentNullException>(() => directionContextStrategy.SetCommand(command));
        }
    }
}
