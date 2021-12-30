using HelloWorldBlazor.Interfaces;
using Microsoft.AspNetCore.Components;

namespace HelloWorldBlazor.Pages
{
    public partial class Index : ComponentBase
    {
        [Inject]
        private IPersonRepository PersonRepository { get; set; }

        private IPerson _currentSelectedPerson;

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
