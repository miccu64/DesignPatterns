namespace DesignPatterns.Builder.Utils
{
    internal static class NameUtils
    {
        public static void ValidateClassOrFieldName(string fieldName)
        {
            if (string.IsNullOrEmpty(fieldName))
                throw new ArgumentNullException(nameof(fieldName));
            if (char.IsAsciiDigit(fieldName[0]))
                throw new ArgumentException("Field name cannot start with number.");
            if (fieldName.Any(c => !char.IsAsciiLetterOrDigit(c) && c != '_'))
                throw new ArgumentException("Field name contains incorrect letters.");
        }
    }
}
