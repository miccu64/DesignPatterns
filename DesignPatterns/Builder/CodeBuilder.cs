using DesignPatterns.Builder.Elements;
using DesignPatterns.Builder.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Builder
{
    public class CodeBuilder
    {
        private readonly string _className;
        private readonly List<Field> _fields = new List<Field>();

        public CodeBuilder(string className)
        {
            NameUtils.ValidateClassOrFieldName(className);

            _className = className;
        }

        public CodeBuilder AddField(string field, string type)
        {
            bool alreadyContainsField = _fields.Any(f => f.FieldName == field);
            if (alreadyContainsField)
                throw new ArgumentException($"Duplicate of field named: {field}.");

            _fields.Add(new Field(field, type));

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
