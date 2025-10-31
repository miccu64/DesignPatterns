namespace DesignPatterns.Visitor.Abstractions
{
    public abstract class Expression
    {
        public abstract void Accept(ExpressionVisitor ev);
    }
}
