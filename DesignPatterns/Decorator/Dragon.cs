using DesignPatterns.Decorator.Interfaces;
using DesignPatterns.Decorator.Models;

namespace DesignPatterns.Decorator
{
    public class Dragon : IBird, ILizard
    {
        public int Age
        {
            get
            {
                return _bird.Age;
            }
            set
            {
                _bird.Age = value;
                _lizard.Age = value;
            }
        }

        private readonly IBird _bird = new Bird();
        private readonly ILizard _lizard = new Lizard();

        public string Fly()
        {
            return _bird.Fly();
        }

        public string Crawl()
        {
            return _lizard.Crawl();
        }
    }
}
