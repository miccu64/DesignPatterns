using DesignPatterns.Visitor;
using Xunit;

namespace DesignPatterns.Tests.Tests.Visitor
{
    public class ExpressionsTests
    {
        [Fact]
        public void Simple_Addition()
        {
            // Arrange
            AdditionExpression expression = new(new Value(2), new Value(3));
            ExpressionPrinter printer = new();

            // Act
            printer.Visit(expression);

            // Assert
            Assert.Equal("(2+3)", printer.ToString());
        }


        [Fact]
        public void Simple_Multiplication()
        {
            // Arrange
            MultiplicationExpression expression = new(new Value(2), new Value(3));
            ExpressionPrinter printer = new();

            // Act
            printer.Visit(expression);

            // Assert
            Assert.Equal("2*3", printer.ToString());
        }
    }
}
