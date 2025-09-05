using DesignPatterns.TemplateMethod.Models;

namespace DesignPatterns.TemplateMethod
{
    public class TemporaryCardDamageGame : CardGame
    {
        public TemporaryCardDamageGame(Creature[] creatures)
            : base(creatures)
        {
        }

        protected override void Hit(Creature attacker, Creature other)
        {
            if (other.Health <= attacker.Attack)
                other.Health -= attacker.Attack;
        }
    }
}
