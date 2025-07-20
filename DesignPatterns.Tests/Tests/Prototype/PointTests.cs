using DesignPatterns.Prototype.Models;
using Xunit;

namespace DesignPatterns.Tests.Tests.Prototype
{
    public class PointTests
    {
        [Fact]
        public void Should_Create_Deep_Copy()
        {
            // Arrange
            Point point = new()
            {
                X = 1,
                Y = 2
            };

            // Act
            Point copy = point.DeepCopy();

            // Assert
            Assert.NotSame(point, copy);
            Assert.Equal(point.X, copy.X);
            Assert.Equal(point.Y, copy.Y);
        }
    }
}
