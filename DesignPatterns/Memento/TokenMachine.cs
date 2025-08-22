using DesignPatterns.Memento.Models;
using System.Collections.Generic;

namespace DesignPatterns.Memento
{
    public class TokenMachine
    {
        public List<Token> Tokens { get; }

        public TokenMachine()
        {
            Tokens = new List<Token>();
        }

        public TokenMachineMemento AddToken(int value)
        {
            Tokens.Add(new Token(value));

            return new TokenMachineMemento(Tokens.Count);
        }

        public TokenMachineMemento AddToken(Token token)
        {
            return AddToken(token.Value);
        }

        public void Revert(TokenMachineMemento m)
        {
            Tokens.RemoveRange(m.TokensCount, Tokens.Count - m.TokensCount);
        }
    }
}
