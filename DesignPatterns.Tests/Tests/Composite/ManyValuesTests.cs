using DesignPatterns.Composite;
using Xunit;

namespace DesignPatterns.Tests.Tests.Composite
{
    public class ManyValuesTests
    {
        [Fact]
        public void Sum_Should_Equal_Initial_Value()
        {
            // Arrange
            List<int> values = [1, 2, 3, 4, 5, 6];
            ManyValues manyValues = [.. values];

            // Act
            int sum = manyValues.Sum();

            // Assert
            int expectedSum = values.Sum();
            Assert.Equal(expectedSum, sum);
        }
    }
}
