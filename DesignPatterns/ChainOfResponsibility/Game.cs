using DesignPatterns.ChainOfResponsibility.Models;
using System.Collections.Generic;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Game
    {
        public readonly IList<Creature> Creatures = new List<Creature>();
    }
}
