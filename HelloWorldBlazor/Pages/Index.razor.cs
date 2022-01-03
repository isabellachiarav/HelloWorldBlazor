using HelloWorldBlazor.Components;
using HelloWorldBlazor.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using MudBlazor;

namespace HelloWorldBlazor.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        private IPersonRepository PersonRepository { get; set; }

        private IPerson _currentSelectedPerson;
        private bool _success;
        private string[] _errors = { };
        private MudForm _form;
        private PersonForm _personForm;

        private void SetCurrentSelectionOnClick(IPerson person)
        {
            _currentSelectedPerson = person;
            _personForm.SetFormTarget(person);

            StateHasChanged();
        }

        private void AddPersonOnClickEventCallback()
        {
            StateHasChanged();
        }

        private void DeletePersonOnClick()
        {
            PersonRepository.TryDeletePerson(_currentSelectedPerson.Id);
            StateHasChanged();
        }

        

        
       
    }
}
