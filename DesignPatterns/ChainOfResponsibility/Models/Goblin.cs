using System.Linq;

namespace DesignPatterns.ChainOfResponsibility.Models
{
    public class Goblin : Creature
    {
        public override int Attack
        {
            get => base.Attack + _game.Creatures.Where(creature => creature != this)
                .Sum(creature => creature.AttackBonus);
        }

        public override int Defense
        {
            get => base.Defense + _game.Creatures.Where(creature => creature != this)
                .Sum(creature => creature.DefenseBonus);
        }

        public override int AttackBonus => 0;
        public override int DefenseBonus => 1;

        protected override int BaseAttack => 1;
        protected override int BaseDefense => 1;

        private readonly Game _game;

        public Goblin(Game game)
        {
            _game = game;
        }
    }
}
