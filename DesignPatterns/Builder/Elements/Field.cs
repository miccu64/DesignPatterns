using DesignPatterns.Builder.Utils;

namespace DesignPatterns.Builder.Elements
{
    internal class Field : IComparable<Field>
    {
        private readonly string _field;
        private readonly string _type;

        public Field(string field, string type)
        {
            NameUtils.ValidateClassOrFieldName(field);
            ValidateTypeName(type);

            _field = field;
            _type = type;
        }

        public override string ToString()
        {
            return $"public {_type} {_field};";
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_field);
        }

        public override bool Equals(object? obj)
        {
            return GetHashCode() == obj?.GetHashCode();
        }

        public int CompareTo(Field? other)
        {
            return GetHashCode() - (other?.GetHashCode() ?? 0);
        }

        private static void ValidateTypeName(string typeName)
        {
            List<string> allowedTypes =
            [
                "string",
                "int"
            ];
            if (!allowedTypes.Contains(typeName))
                throw new ArgumentException("Incorrect type name.");
        }
    }
}
