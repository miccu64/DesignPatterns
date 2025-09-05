using DesignPatterns.TemplateMethod.Models;

namespace DesignPatterns.TemplateMethod
{
    public class PermanentCardDamageGame : CardGame
    {
        public PermanentCardDamageGame(Creature[] creatures)
            : base(creatures)
        {
        }

        protected override void Hit(Creature attacker, Creature other)
        {
            other.Health -= attacker.Attack;
        }
    }
}
