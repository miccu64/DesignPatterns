using DesignPatterns.Decorator.Interfaces;

namespace DesignPatterns.Decorator.Models
{
    public class Lizard : ILizard
    {
        public int Age { get; set; }

        public string Crawl()
        {
            return (Age > 1) ? "crawling" : "too young";
        }
    }
}
