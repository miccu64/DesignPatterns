using DesignPatterns.Composite.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatterns.Composite
{
    public class SingleValue : IValueContainer
    {
        public int Value;

        public IEnumerator<int> GetEnumerator()
        {
            yield return Value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
