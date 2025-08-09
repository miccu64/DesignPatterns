namespace DesignPatterns.Interpreter.Models
{
    public class OperatorToken : Token<OperatorType>
    {
        public OperatorToken(OperatorType value) : base(value)
        {
        }

        public override string ToString()
        {
            switch (Value)
            {
                case OperatorType.Plus:
                    return "+";
                case OperatorType.Minus:
                    return "-";
                default:
                    throw new System.Exception("Not known OperatorType");
            }
        }
    }
}
