using HelloWorldBlazor.Classes;
using HelloWorldBlazor.Interfaces;
using Microsoft.AspNetCore.Components;
using MudBlazor;

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

        private string _firstName = string.Empty;
        private string _lastName = string.Empty;
        private Guid? _previousPersonId = Guid.Empty;

        protected override void OnParametersSet()
        {
            if((Person?.Id ?? null) != _previousPersonId)
            {
                Person = new Person(string.Empty, string.Empty);
            }

            _previousPersonId = Person.Id;

            base.OnParametersSet();
        }

        private void AddPersonOnClick()
        {
            PersonRepository.TryAddPerson(new Person(_firstName, _lastName));

            if(AddPersonEventCallback.HasDelegate)
                AddPersonEventCallback.InvokeAsync();
        }

        bool success;
        string[] errors = { };
        MudTextField<string> pwField1;
        MudForm form;


    }
}
