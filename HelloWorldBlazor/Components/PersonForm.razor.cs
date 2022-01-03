using HelloWorldBlazor.Classes;
using HelloWorldBlazor.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace HelloWorldBlazor.Components
{
    public partial class PersonForm : ComponentBase
    {
        [Inject]
        private IPersonRepository PersonRepository { get; set; }

        [Parameter]
        public EventCallback AddPersonEventCallback { get; set; }
        [Parameter]
        public IPerson Person { get; set; }

        public PersonFormModel _personFormModel = new PersonFormModel();

        private void OnValidSubmit(EditContext context)
        {
            if (Person is null)
            {
                AddPersonOnClick();
            }
            else
            {
                UpdatePersonOnClick();
            }

            StateHasChanged();
        }

        private void UpdatePersonOnClick()
        {
            Person.FirstName = _personFormModel.FirstName;
            Person.LastName = _personFormModel.LastName;

            PersonRepository.TryUpdatePerson(Person);

            if (AddPersonEventCallback.HasDelegate)
                AddPersonEventCallback.InvokeAsync();
        }

        private void AddPersonOnClick()
        {
            PersonRepository.TryAddPerson(
                new Person(_personFormModel.FirstName, _personFormModel.LastName)
            );

            if (AddPersonEventCallback.HasDelegate)
                AddPersonEventCallback.InvokeAsync();

            _personFormModel = new PersonFormModel();
        }

        public void SetFormTarget(IPerson person)
        {
            _personFormModel = new PersonFormModel
            {
                FirstName = person.FirstName,
                LastName = person.LastName
            };

            StateHasChanged();
        }

        public class PersonFormModel : IPerson
        {
            public Guid Id { get; } = Guid.NewGuid();
            public string FirstName { get; set; } = string.Empty;
            public string LastName { get; set; }
            public string DisplayName => $"{FirstName} {LastName}";
        }
    }
}
