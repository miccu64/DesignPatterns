using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Models
{
    public class OrdinaryDiscriminantStrategy : IDiscriminantStrategy
    {
        public double CalculateDiscriminant(double a, double b, double c)
        {
            return b * b - (4 * a * c);
        }
    }
}
