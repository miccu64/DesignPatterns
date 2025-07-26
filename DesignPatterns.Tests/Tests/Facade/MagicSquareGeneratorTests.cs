using DesignPatterns.Facade;
using Xunit;

namespace DesignPatterns.Tests.Tests.Facade
{
    public class MagicSquareGeneratorTests
    {
        [Fact]
        public void Should_Generate()
        {
            // Arrange
            MagicSquareGenerator magicSquareGenerator = new();
            const int size = 3;

            // Act
            var result = magicSquareGenerator.Generate(size);

            // Assert
            Assert.Equal(size, result.Count);
            Assert.Equal(size, result[0].Count);
        }
    }
}
