using DesignPatterns.Strategy.Interfaces;
using System;
using System.Numerics;

namespace DesignPatterns.Strategy
{
    public class QuadraticEquationSolver
    {
        private readonly IDiscriminantStrategy _strategy;

        public QuadraticEquationSolver(IDiscriminantStrategy strategy)
        {
            _strategy = strategy;
        }

        public Tuple<Complex, Complex> Solve(double a, double b, double c)
        {
            double discriminant = _strategy.CalculateDiscriminant(a, b, c);
            if (discriminant == double.NaN)
            {
                return Tuple.Create(
                    new Complex(double.NaN, double.NaN),
                    new Complex(double.NaN, double.NaN)
                );
            }

            Complex xPlus = ((-1) * b + Complex.Sqrt(discriminant)) / (2 * a);
            Complex xMinus = ((-1) * b - Complex.Sqrt(discriminant)) / (2 * a);

            return Tuple.Create(xPlus, xMinus);
        }
    }
}
