using HelloWorldBlazor.Interfaces;
using Microsoft.AspNetCore.Components;

namespace HelloWorldBlazor.Components
{
    public partial class PersonRenderer : ComponentBase
    {
        [Parameter]
        public IPerson Person { get; set; }
        [Parameter]
        public EventCallback<IPerson> OnClickPersonEventCallback { get; set; }

        UpdatedPersonForm _model = new UpdatedPersonForm();

        private void FireOnClickPersonEventCallback()
        {
            if (OnClickPersonEventCallback.HasDelegate)
                OnClickPersonEventCallback.InvokeAsync(Person);
        }

        public class UpdatedPersonForm
        {
            public string UpdatedFirstName { get; set; }
            public string UpdatedLastName { get; set; }
        }
    }
}
