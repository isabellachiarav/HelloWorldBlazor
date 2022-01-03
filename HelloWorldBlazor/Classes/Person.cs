using HelloWorldBlazor.Interfaces;

namespace HelloWorldBlazor.Classes
{
    public class Person : IPerson
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public Guid Id { get; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName => $"{FirstName} {LastName}";
    }
}
