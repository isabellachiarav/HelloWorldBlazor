using HelloWorldBlazor.Interfaces;

namespace HelloWorldBlazor.Classes
{
    public class Person : IPerson
    {
        public Guid Id { get; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName => $"{FirstName} {LastName}";
        
    }
}
