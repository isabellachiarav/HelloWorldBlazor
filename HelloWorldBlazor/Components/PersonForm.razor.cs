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

        private string _firstName = string.Empty;
        private string _lastName = string.Empty;

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
