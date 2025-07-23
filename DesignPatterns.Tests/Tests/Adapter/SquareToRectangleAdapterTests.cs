using DesignPatterns.Adapter;
using DesignPatterns.Adapter.Extensions;
using DesignPatterns.Adapter.Models;
using Xunit;

namespace DesignPatterns.Tests.Tests.Adapter
{
    public class SquareToRectangleAdapterTests
    {
        [Fact]
        public void Area_Should_Be_Equal_When_Treated_As_Rectangle_And_As_Square()
        {
            // Arrange
            Square square = new(3);

            // Act
            SquareToRectangleAdapter adapter = new(square);
            int areaAsRectangle = adapter.Area();
            int areaAsSquare = square.Side * square.Side;

            // Assert
            Assert.Equal(areaAsSquare, areaAsRectangle);
        }
    }
}
