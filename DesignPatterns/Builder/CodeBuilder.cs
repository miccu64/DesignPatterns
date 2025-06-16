using DesignPatterns.Builder.Elements;
using DesignPatterns.Builder.Utils;
using System.Text;

namespace DesignPatterns.Builder
{
    public class CodeBuilder
    {
        private readonly string _className;
        private readonly SortedSet<Field> _fields = [];

        public CodeBuilder(string className)
        {
            NameUtils.ValidateClassOrFieldName(className);

            _className = className;
        }

        public CodeBuilder AddField(string field, string type)
        {
            bool added = _fields.Add(new Field(field, type));
            if (!added)
                throw new ArgumentException($"Duplicate of field named: {field}.");

            return this;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder()
                .AppendLine($"public class {_className}")
                .AppendLine("{");

            foreach (Field field in _fields)
                sb.AppendLine($"  {field}");

            return sb.Append('}')
                .ToString();
        }
    }
}
