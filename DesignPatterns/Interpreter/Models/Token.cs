using DesignPatterns.Interpreter.Interfaces;

namespace DesignPatterns.Interpreter.Models
{
    public abstract class Token<T> : IToken
    {
        public T Value { get; }

        object IToken.Value => Value;

        public Token(T value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
