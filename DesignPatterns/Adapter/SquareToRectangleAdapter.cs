using DesignPatterns.Adapter.Interfaces;
using DesignPatterns.Adapter.Models;

namespace DesignPatterns.Adapter
{
    public class SquareToRectangleAdapter : IRectangle
    {
        public int Width => _square.Side;
        public int Height => _square.Side;

        private readonly Square _square;

        public SquareToRectangleAdapter(Square square)
        {
            _square = square;
        }
    }
}
