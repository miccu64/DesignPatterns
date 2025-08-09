using DesignPatterns.Interpreter;
using Xunit;

namespace DesignPatterns.Tests.Tests.Interpreter
{
    public class ExpressionProcessorTests
    {
        [Fact]
        public void Should_Return_6()
        {
            // Arrange
            const string expression = "1+2+3";
            ExpressionProcessor processor = new();

            // Act
            int result = processor.Calculate(expression);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void Should_Return_0()
        {
            // Arrange
            const string expression = "1+2+xy";
            ExpressionProcessor processor = new();

            // Act
            int result = processor.Calculate(expression);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void Should_Return_5()
        {
            // Arrange
            const string expression = "10-2-x";
            ExpressionProcessor processor = new();

            // Act
            int result = processor.Calculate(expression);

            // Assert
            Assert.Equal(0, result);
        }
    }
}
