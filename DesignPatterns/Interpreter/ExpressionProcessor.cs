using DesignPatterns.Interpreter.Interfaces;
using DesignPatterns.Interpreter.Models;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Interpreter
{
    public class ExpressionProcessor
    {
        public Dictionary<char, int> Variables = new Dictionary<char, int>();

        public int Calculate(string expression)
        {
            if (string.IsNullOrWhiteSpace(expression))
                return 0;

            IEnumerable<IToken> tokens = Lex(expression);
            if (tokens == null)
                return 0;

            return Parse(tokens);
        }

        private IEnumerable<IToken> Lex(string expression)
        {
            List<IToken> tokens = new List<IToken>();

            expression = expression.Trim().Replace(" ", "");

            string numbersInRow = "";
            for (int index = 0; index < expression.Length; index++)
            {
                char c = expression[index];
                if (char.IsDigit(c))
                {
                    numbersInRow += c;
                }
                else if (c == '+' || c == '-')
                {
                    if (numbersInRow.Length == 0)
                        return null;

                    tokens.Add(new NumberToken(int.Parse(numbersInRow)));
                    numbersInRow = "";

                    tokens.Add(new OperatorToken(c == '+' ? OperatorType.Plus : OperatorType.Minus));
                }
                else if (Variables.TryGetValue(c, out int num))
                {
                    if (numbersInRow.Length != 0)
                        return null;

                    tokens.Add(new NumberToken(num));
                }
                else
                {
                    return null;
                }
            }

            if (numbersInRow.Length > 0)
                tokens.Add(new NumberToken(int.Parse(numbersInRow)));

            return tokens;
        }

        private int Parse(IEnumerable<IToken> tokens)
        {
            int result = ((NumberToken)tokens.ElementAt(0)).Value;

            for (int i = 1; i < tokens.Count(); i += 2)
            {
                OperatorToken operatorToken = (OperatorToken)tokens.ElementAt(i);
                NumberToken numberToken = (NumberToken)tokens.ElementAt(i + 1);

                switch (operatorToken.Value)
                {
                    case OperatorType.Plus:
                        result += numberToken.Value;
                        break;
                    case OperatorType.Minus:
                        result -= numberToken.Value;
                        break;
                    default:
                        throw new System.Exception("Not known OperatorType");
                }
            }

            return result;
        }
    }
}
