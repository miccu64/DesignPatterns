using DesignPatterns.Flyweight.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Flyweight
{
    public class Sentence
    {
        private readonly List<WordToken> _tokens;

        public Sentence(string plainText)
        {
            _tokens = plainText.Split(' ')
                .Select(word => new WordToken { Word = word })
                .ToList();
        }

        public WordToken this[int index]
        {
            get
            {
                return _tokens[index];
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            foreach (WordToken token in _tokens)
            {
                builder
                    .Append(token.Capitalize ? token.Word.ToUpper() : token.Word)
                    .Append(' ');
            }

            return builder.ToString().Trim();
        }
    }
}
