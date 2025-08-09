namespace DesignPatterns.Interpreter.Models
{
    public class NumberToken : Token<int>
    {
        public NumberToken(int value) : base(value)
        {
        }
    }
}
