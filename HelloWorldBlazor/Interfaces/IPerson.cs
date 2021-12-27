namespace HelloWorldBlazor.Interfaces
{
    public interface IPerson
    {
        Guid Id { get; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string DisplayName { get; }
    }
}
