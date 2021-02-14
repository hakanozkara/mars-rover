using Mars.Rover.Domain.Abstracts;
using Mars.Rover.Domain.Concretes;
using Mars.Rover.Services.Abstracts;
using Mars.Rover.Services.Concretes;
using System;
using Xunit;

namespace Mars.Rover.Tests
{
    public class SurfaceFactoryTests
    {
        [Fact]
        public void IsNotNull_Surface()
        {
            ICoordinate coordinate = new Coordinate(0, 0);
            ISurfaceFactory surfaceFactory = new SurfaceFactory();

            surfaceFactory.CreateSurface(coordinate);
            var surface = surfaceFactory.Surface;

            Assert.NotNull(surface);
        }

        [Fact]
        public void IsThrowArgumentNullException_CoordinateIsNull()
        {
            ICoordinate coordinate = null;
            ISurfaceFactory surfaceFactory = new SurfaceFactory();

            Assert.Throws<ArgumentNullException>(() => surfaceFactory.CreateSurface(coordinate));
        }

        [Theory]
        [InlineData(-1, -1)]
        [InlineData(-1, 0)]
        [InlineData(0, -1)]
        public void IsThrowArgumentOutOfRangeException_Coordinate_X_And_Y_Minus(int x, int y)
        {
            ICoordinate coordinate = new Coordinate(x, y);
            ISurfaceFactory surfaceFactory = new SurfaceFactory();

            Assert.Throws<ArgumentOutOfRangeException>(() => surfaceFactory.CreateSurface(coordinate));
        }

    }
}
