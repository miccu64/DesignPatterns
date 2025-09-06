﻿using DesignPatterns.Strategy.Interfaces;

namespace DesignPatterns.Strategy.Models
{
    public class RealDiscriminantStrategy : IDiscriminantStrategy
    {
        public double CalculateDiscriminant(double a, double b, double c)
        {
            double result = b * b - (4 * a * c);

            return result < 0
                ? double.NaN
                : result;
        }
    }
}
