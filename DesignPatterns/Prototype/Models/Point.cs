namespace DesignPatterns.Prototype.Models
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point DeepCopy()
        {
            return (Point)MemberwiseClone();
        }
    }
}
