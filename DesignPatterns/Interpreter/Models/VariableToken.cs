namespace DesignPatterns.Interpreter.Models
{
    public class VariableToken : Token<char>
    {
        public VariableToken(char value) : base(value)
        {
        }
    }
}
