using DesignPatterns.Proxy.Models;

namespace DesignPatterns.Proxy
{
    public class ResponsiblePerson
    {
        private readonly Person _person;

        public int Age
        {
            get => _person.Age;
            set => _person.Age = value;
        }

        public ResponsiblePerson(Person person)
        {
            _person = person;
        }

        public string Drink()
        {
            return _person.Age < 18
                ? "too young"
                : _person.Drink();
        }

        public string Drive()
        {
            return _person.Age < 16
                ? "too young"
                : _person.Drive();
        }

        public string DrinkAndDrive()
        {
            return "dead";
        }
    }
}
