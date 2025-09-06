using DesignPatterns.Strategy;
using DesignPatterns.Strategy.Models;
using System.Numerics;
using Xunit;

namespace DesignPatterns.Tests.Tests.Strategy
{
    public class Solver_OrdinaryStrategyTests
    {
        [Fact]
        public void Should_Return_Value_On_Negative_Discriminant()
        {
            // Arrange
            const double a = 4;
            const double b = 1;
            const double c = 1;

            OrdinaryDiscriminantStrategy ordinaryStrategy = new();
            QuadraticEquationSolver solver = new(ordinaryStrategy);

            // Act
            Tuple<Complex, Complex> result = solver.Solve(a, b, c);

            // Assert
            Assert.NotEqual(Complex.NaN, result.Item1);
            Assert.NotEqual(Complex.NaN, result.Item2);
        }

        [Fact]
        public void Should_Return_Value_On_Positive_Discriminant()
        {
            // Arrange
            const double a = 1;
            const double b = 2;
            const double c = 1;

            OrdinaryDiscriminantStrategy ordinaryStrategy = new();
            QuadraticEquationSolver solver = new(ordinaryStrategy);

            // Act
            Tuple<Complex, Complex> result = solver.Solve(a, b, c);

            // Assert
            Assert.Equal(-1, result.Item1);
            Assert.Equal(-1, result.Item2);
        }
    }
}
