namespace HelloWorldBlazor.Interfaces
{
    public interface IPersonRepository
    {
        IEnumerable<IPerson> GetPeople();
        bool TryAddPerson(IPerson person);
        bool TryDeletePerson(Guid id);
        bool TryUpdatePerson(IPerson person);
    }
}
