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
        bool success;
        string[] errors = { };
        MudForm form;

        private void SetCurrentSelectionOnClick(IPerson person)
        {
            _currentSelectedPerson = person;

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
