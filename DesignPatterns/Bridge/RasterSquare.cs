namespace DesignPatterns.Bridge
{
    public class RasterSquare : Square
    {
        public RasterSquare() : base(new VectorRenderer())
        {
        }
    }
}
