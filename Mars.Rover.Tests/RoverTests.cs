using Mars.Rover.Domain.Abstracts;
using Mars.Rover.Domain.Concretes;
using Mars.Rover.Domain.Enums;
using Mars.Rover.Services.Abstracts;
using Mars.Rover.Services.Concretes;
using Mars.Rover.Services.Concretes.DirectionStrategy;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Mars.Rover.Tests
{
    public class RoverTests
    {
        [Theory]
        [InlineData(-1, -1, 0)]
        [InlineData(-1, -1, 1)]
        [InlineData(-1, 0, 1)]
        [InlineData(0, -1, 1)]
        public void IsThrowArgumentOutOfRangeException_New_RoverPosition(int x, int y, int direction)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new RoverPosition(x, y, (Direction)direction));
        }

        [Fact]
        public void IsNotNull_Rover()
        {
            ICoordinate coordinate = new Coordinate(5, 5);
            ISurfaceFactory surfaceFactory = new SurfaceFactory();
            surfaceFactory.CreateSurface(coordinate);

            IDirectionContextStrategy directionContextStrategy = new DirectionContextStrategy();
            IRoverPosition position = new RoverPosition(0, 0, Direction.N);
            IRover rover = new Mars.Rover.Services.Concretes.Rover(surfaceFactory.Surface, position, directionContextStrategy);

            Assert.NotNull(rover);
        }

        [Fact]
        public void IsEqual_Surface_5_5_And_Rover_Position_1_2_N_Execute_Command_LMLMLMLMM_Result_Is_1_3_N()
        {
            ICoordinate coordinate = new Coordinate(5, 5);
            ISurfaceFactory surfaceFactory = new SurfaceFactory();
            surfaceFactory.CreateSurface(coordinate);

            IDirectionContextStrategy directionContextStrategy = new DirectionContextStrategy();
            IRoverPosition position = new RoverPosition(1, 2, Direction.N);
            IRover rover = new Mars.Rover.Services.Concretes.Rover(surfaceFactory.Surface, position, directionContextStrategy);

            rover.Execute("LMLMLMLMM");

            Assert.Equal("1 3 N", rover.ToString());
        }

        [Fact]
        public void IsEqual_Surface_5_5_And_Rover_Position_3_3_E_Execute_Command_MMRMMRMRRM_Result_Is_5_1_E()
        {
            ICoordinate coordinate = new Coordinate(5, 5);
            ISurfaceFactory surfaceFactory = new SurfaceFactory();
            surfaceFactory.CreateSurface(coordinate);

            IDirectionContextStrategy directionContextStrategy = new DirectionContextStrategy();
            IRoverPosition position = new RoverPosition(3, 3, Direction.E);
            IRover rover = new Mars.Rover.Services.Concretes.Rover(surfaceFactory.Surface, position, directionContextStrategy);

            rover.Execute("MMRMMRMRRM");

            Assert.Equal("5 1 E", rover.ToString());
        }
    }
}
