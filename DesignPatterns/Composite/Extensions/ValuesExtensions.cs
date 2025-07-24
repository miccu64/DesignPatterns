using DesignPatterns.Composite.Interfaces;
using System.Collections.Generic;

namespace DesignPatterns.Composite.Extensions
{
    public static class ValuesExtensions
    {
        public static int Sum(this List<IValueContainer> containers)
        {
            int result = 0;

            foreach (IValueContainer c in containers)
                foreach (int i in c)
                    result += i;

            return result;
        }
    }
}
