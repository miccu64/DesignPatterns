using DesignPatterns.Bridge.Interfaces;
using DesignPatterns.Bridge.Models;

namespace DesignPatterns.Bridge
{
    public class Square : Shape
    {
        public Square(IRenderer renderer) : base(renderer)
        {
            Name = "Square";
        }
    }
}
