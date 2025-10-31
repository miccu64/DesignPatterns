using DesignPatterns.Visitor.Abstractions;

namespace DesignPatterns.Visitor
{
    public class AdditionExpression : Expression
    {
        public readonly Expression LHS;
        public readonly Expression RHS;

        public AdditionExpression(Expression lhs, Expression rhs)
        {
            LHS = lhs;
            RHS = rhs;
        }

        public override void Accept(ExpressionVisitor ev)
        {
            ev.Visit(this);
        }
    }
}
