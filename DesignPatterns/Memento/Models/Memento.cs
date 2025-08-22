namespace DesignPatterns.Memento.Models
{
    public class TokenMachineMemento
    {
        public int TokensCount { get; }

        public TokenMachineMemento(int tokensCount)
        {
            TokensCount = tokensCount;
        }
    }
}
