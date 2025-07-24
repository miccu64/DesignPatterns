namespace DesignPatterns.Bridge
{
    public class VectorSquare : Square
    {
        public VectorSquare() : base(new RasterRenderer())
        {
        }
    }
}
