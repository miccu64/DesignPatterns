namespace DesignPatterns.ChainOfResponsibility.Models
{
    public abstract class Creature
    {
        public virtual int Attack { get => BaseAttack; }
        public virtual int Defense { get => BaseDefense; }
        public abstract int AttackBonus { get; }
        public abstract int DefenseBonus { get; }
        protected abstract int BaseAttack { get; }
        protected abstract int BaseDefense { get; }
    }
}
