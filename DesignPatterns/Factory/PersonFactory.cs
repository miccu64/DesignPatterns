using DesignPatterns.Factory.Models;
using System;

namespace DesignPatterns.Factory
{
    public class PersonFactory
    {
        private int IdCounter = 0;

        public Person CreatePerson(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Name is not provided.");

            return new Person()
            {
                Id = IdCounter++,
                Name = name
            };
        }
    }
}
