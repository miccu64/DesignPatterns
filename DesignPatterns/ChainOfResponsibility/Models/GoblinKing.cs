namespace DesignPatterns.ChainOfResponsibility.Models
{
    public class GoblinKing : Goblin
    {
        public override int AttackBonus => 1;

        protected override int BaseAttack => 3;
        protected override int BaseDefense => 3;

        public GoblinKing(Game game) : base(game)
        {
        }
    }
}
