using DesignPatterns.Builder.Utils;
using System;
using System.Collections.Generic;

namespace DesignPatterns.Builder.Elements
{
    internal class Field
    {
        public string FieldName { get; }
        public string TypeName { get; }

        public Field(string field, string type)
        {
            NameUtils.ValidateClassOrFieldName(field);
            ValidateTypeName(type);

            FieldName = field;
            TypeName = type;
        }

        public override string ToString()
        {
            return $"public {TypeName} {FieldName};";
        }

        private static void ValidateTypeName(string typeName)
        {
            List<string> allowedTypes = new List<string>
            {
                "string",
                "int"
            };
            if (!allowedTypes.Contains(typeName))
                throw new ArgumentException("Incorrect type name.");
        }
    }
}
