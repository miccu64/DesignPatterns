using DesignPatterns.Adapter.Interfaces;

namespace DesignPatterns.Adapter.Extensions
{
    public static class IRectangleExtensions
    {
        public static int Area(this IRectangle rectangle)
        {
            return rectangle.Width * rectangle.Height;
        }
    }
}
