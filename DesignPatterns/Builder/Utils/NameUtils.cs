using System;
using System.Linq;

namespace DesignPatterns.Builder.Utils
{
    internal static class NameUtils
    {
        public static void ValidateClassOrFieldName(string fieldName)
        {
            if (string.IsNullOrEmpty(fieldName))
                throw new ArgumentNullException(nameof(fieldName));
            if (char.IsDigit(fieldName[0]))
                throw new ArgumentException("Field name cannot start with number.");
            if (fieldName.Any(c => !char.IsLetterOrDigit(c) && IsAscii(c) && c != '_'))
                throw new ArgumentException("Field name contains incorrect letters.");
        }

        private static bool IsAscii(char c)
        {
            return c < 128;
        }
    }
}
