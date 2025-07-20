using DesignPatterns.Prototype.Models;

namespace DesignPatterns.Prototype
{
    public class LinePrototype
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public string Name { get; set; }

        public LinePrototype DeepCopy()
        {
            LinePrototype copy = (LinePrototype)MemberwiseClone();

            copy.Start = Start.DeepCopy();
            copy.End = End.DeepCopy();

            return copy;
        }
    }
}
