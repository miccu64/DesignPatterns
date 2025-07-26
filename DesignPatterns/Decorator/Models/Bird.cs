using DesignPatterns.Decorator.Interfaces;

namespace DesignPatterns.Decorator.Models
{
    public class Bird : IBird
    {
        public int Age { get; set; }

        public string Fly()
        {
            return (Age < 10) ? "flying" : "too old";
        }
    }
}
