using HelloWorldBlazor.Interfaces;

namespace HelloWorldBlazor.Classes
{
    public class PersonRepository : IPersonRepository
    {
        private List<IPerson> _people = new List<IPerson>();

        public PersonRepository()
        {
            _people.Add(new Person("Isabella","Chiaravalloti"));
            _people.Add(new Person("DarkMatter","Employee"));
        }

        public bool TryAddPerson(IPerson person)
        {
            IPerson persistedInstance = _people.FirstOrDefault(p => p.Id == person.Id);

            if (persistedInstance is not null)
                return false;
            
            _people.Add(person);
            return true;
        }

        public IEnumerable<IPerson> GetPeople()
        {
            return _people;
        }

        public bool TryUpdatePerson(IPerson person)
        {
            IPerson persistedInstance = _people.FirstOrDefault(p => p.Id == person.Id);

            if (persistedInstance is null)
                return false;

            persistedInstance.FirstName = person.FirstName;
            persistedInstance.LastName = person.LastName;
            return true;
        }

        public bool TryDeletePerson(Guid id)
        {
            IPerson persistedInstance = _people.FirstOrDefault(p => p.Id == id);

            if (persistedInstance is null)
                return false;

            _people.Remove(persistedInstance);
            return true;
        }
        // crud
    }
}
