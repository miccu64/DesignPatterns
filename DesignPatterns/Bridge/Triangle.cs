using DesignPatterns.Bridge.Interfaces;
using DesignPatterns.Bridge.Models;

namespace DesignPatterns.Bridge
{
    public class Triangle : Shape
    {
        public Triangle(IRenderer renderer) : base(renderer)
        {
            Name = "Triangle";
        }
    }
}
