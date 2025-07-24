using DesignPatterns.Composite;
using Xunit;

namespace DesignPatterns.Tests.Tests.Composite
{
    public class SingleValueTests
    {
        [Fact]
        public void Sum_Should_Equal_Initial_Value()
        {
            // Arrange
            int value = 3;
            SingleValue singleValue = new()
            {
                Value = value
            };

            // Act
            int sum = singleValue.Sum();

            // Assert
            Assert.Equal(value, sum);
        }
    }
}
